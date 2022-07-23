using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CloudRockers.Domain.Models
{
    [ExcludeFromCodeCoverage]
    public class SearchResultModel
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public string HighLightedText { get; set; }
    }
}
