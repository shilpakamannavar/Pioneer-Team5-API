using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CloudRockers.Domain.Constants
{
    [ExcludeFromCodeCoverage]
    public static class CognitiveSearchConstants
    {
        public const string MergedContent = "merged_content";
        public const string PreTag = "<b>";
        public const string PostTag = "</b>";
        public const string MetadatasStorageName = "metadata_storage_name";
        public const string MetadataStoragePath = "metadata_storage_path";
        public const string All = "*";
    }
}
