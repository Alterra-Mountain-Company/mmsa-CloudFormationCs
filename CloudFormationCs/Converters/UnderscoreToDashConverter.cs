﻿using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace CloudFormationCs.Converters
{
    /// <summary>
    /// Converts the object to a string then replaces _ with -
    /// </summary>
    internal class UnderscoreToDashConverter : JsonWriterOnlyBase
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string)
                || objectType == typeof(Enum)
                ;
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString().Replace("_", "-"));
        }
    }
}
