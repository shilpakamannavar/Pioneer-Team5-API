using CloudRockers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CloudRockers.Core.Providers
{
    public interface ISearchRepository
    {
        Task<IList<SearchResultModel>> GetSearchData(string searchText);
    }
}
