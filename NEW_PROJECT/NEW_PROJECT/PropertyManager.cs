using System;
using System.Collections.Generic;
using System.Linq;

namespace NEW_PROJECT
{
    public class PropertyManager
    {
        private List<Property> _properties;
        private IDataManager _dataManager;
        private string _filePath;

        public PropertyManager(string filePath)
        {
            _properties = new List<Property>();
            _filePath = filePath;
            _dataManager = new JsonDataManager(_properties);
            Load();
        }

      
        public List<Property> GetAll()
        {
            return _properties.ToList(); 
        }

        public void Add(Property property)
        {
            _properties.Add(property);
            Save();
        }

        public void Update(Property oldProperty, Property newProperty)
        {
            int index = _properties.IndexOf(oldProperty);
            if (index != -1)
            {
                _properties[index] = newProperty;
                Save();
            }
        }

        public void Delete(Property property)
        {
            _properties.Remove(property);
            Save();
        }

        public Property FindByName(string name)
        {
            return _properties.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void Save()
        {
            _dataManager.SaveToFile(_filePath);
        }

        public void Load()
        {
            _dataManager.LoadFromFile(_filePath);
        }
    }
}
