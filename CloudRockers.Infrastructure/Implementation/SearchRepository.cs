using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Search.Documents;
using Azure.Search.Documents.Models;
using CloudRockers.Core.Providers;
using CloudRockers.Domain.Constants;
using CloudRockers.Domain.Models;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;

namespace CloudRockers.Infrastructure.Implementation
{
    public class SearchRepository : ISearchRepository
    {
        private readonly IOptions<CognitiveSearchOptions> _cognitiveSearchOptions;

        public SearchRepository(IOptions<CognitiveSearchOptions> cognitiveSearchOptions)
        {
            _cognitiveSearchOptions = cognitiveSearchOptions;
        }

        public async Task<IList<SearchResultModel>> GetSearchData(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                searchText = CognitiveSearchConstants.All;
            }
            var cognitiveSearch = _cognitiveSearchOptions.Value;
            var searchClient = new SearchClient(new Uri(cognitiveSearch.SearchUrl), cognitiveSearch.IndexName, new Azure.AzureKeyCredential(cognitiveSearch.AzAPIKey));
            SearchOptions searchOptions = new SearchOptions();
            searchOptions.HighlightFields.Add(CognitiveSearchConstants.MergedContent);
            searchOptions.HighlightPreTag = CognitiveSearchConstants.PreTag;
            searchOptions.HighlightPostTag = CognitiveSearchConstants.PostTag;
            var searchResultList = new List<SearchResultModel>();
            var result = await searchClient.SearchAsync<SearchDocument>(searchText, searchOptions).ConfigureAwait(false);
            var searchResults = result.Value.GetResults();
            foreach (var data in searchResults)
            {
                SearchResultModel searchResultModel = new SearchResultModel();
                searchResultModel.FileName = Convert.ToString(data.Document[CognitiveSearchConstants.MetadatasStorageName]);
                var path = Convert.ToString(data.Document[CognitiveSearchConstants.MetadataStoragePath]);
                path = path.Substring(0, path.Length - 1);
                var bytesData = WebEncoders.Base64UrlDecode(path);
                searchResultModel.FilePath = ASCIIEncoding.ASCII.GetString(bytesData);
                searchResultModel.Description = Convert.ToString(data.Document[CognitiveSearchConstants.MergedContent]);
                if (data.Highlights != null)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    var highLights = data.Highlights[CognitiveSearchConstants.MergedContent].ToList();
                    foreach (var high in highLights)
                    {
                        stringBuilder.Append(high);
                        searchResultModel.HighLightedText = stringBuilder.ToString();
                    }
                }
                searchResultList.Add(searchResultModel);

            }
            return searchResultList;

        }
    }
}
