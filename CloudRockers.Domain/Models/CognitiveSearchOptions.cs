using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CloudRockers.Domain.Models
{
    [ExcludeFromCodeCoverage]
    public class CognitiveSearchOptions
    {
        public string IndexName { get; set; }
        public string SearchUrl { get; set; }
        public string AzAPIKey { get; set; }
    }
}
