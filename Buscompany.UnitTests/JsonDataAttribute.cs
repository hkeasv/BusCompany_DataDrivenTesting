using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Xunit.Sdk;

namespace Buscompany.UnitTests
{
    public class JsonDataAttribute : DataAttribute
    {
        private string _filePath;

        public JsonDataAttribute(string filePath)
        {
            _filePath = filePath;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var fileData = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<object[]>>(fileData);
        }
    }
}
