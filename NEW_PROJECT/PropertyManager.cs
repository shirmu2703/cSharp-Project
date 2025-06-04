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

        // Returns all properties
        public List<Property> GetAll()
        {
            return _properties.ToList(); // Return a copy
        }

        // Adds a new property
        public void Add(Property property)
        {
            _properties.Add(property);
            Save();
        }

        // Updates an existing property
        public void Update(Property oldProperty, Property newProperty)
        {
            int index = _properties.IndexOf(oldProperty);
            if (index != -1)
            {
                _properties[index] = newProperty;
                Save();
            }
        }

        // Deletes a property
        public void Delete(Property property)
        {
            _properties.Remove(property);
            Save();
        }

        // Finds a property by name
        public Property FindByName(string name)
        {
            return _properties.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Saves the property list to file
        public void Save()
        {
            _dataManager.SaveToFile(_filePath);
        }

        // Loads the property list from file
        public void Load()
        {
            _dataManager.LoadFromFile(_filePath);
        }
    }
}
