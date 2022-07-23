using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudRockers.Core.Providers;
using Microsoft.AspNetCore.Mvc;

namespace CloudRockers.SearchEngine.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchRepository _searchRepository;
        public SearchController(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }
        public async Task<IActionResult> Search(string searchText)
        {
            var searchResults = await _searchRepository.GetSearchData(searchText).ConfigureAwait(false);
            return View(searchResults);
        }
    }
}