using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NEW_PROJECT
{
    public class JsonDataManager : IDataManager
    {
        private List<Property> _properties;

        public JsonDataManager(List<Property> properties)
        {
            _properties = properties;
        }

        public void SaveToFile(string filePath)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(_properties, settings);
            File.WriteAllText(filePath, json);
        }

        public void LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                };

                var loaded = JsonConvert.DeserializeObject<List<Property>>(json, settings);
                if (loaded != null)
                {
                    _properties.Clear();
                    _properties.AddRange(loaded);
                }
            }
        }
    }
}
