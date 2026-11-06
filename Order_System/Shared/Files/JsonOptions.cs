using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Order_System.Shared.Files
{
    public static class JsonOptions
    {
        public static readonly JsonSerializerOptions _serializeOptions = new JsonSerializerOptions
        {
            WriteIndented = true,                           
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, 
            AllowTrailingCommas = true                        
        };
    }
}
