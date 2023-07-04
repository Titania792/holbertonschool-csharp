using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// A storage class that serializes and deserializes objects to and from a JSON file.
    /// </summary>
    public class JSONStorage
    {
        private readonly string _filePath;

        /// <summary>
        /// Initializes a new instance of the JSONStorage class.
        /// </summary>
        public JSONStorage()
        {
            _filePath = "storage/inventory_manager.json";
        }

        /// <summary>
        /// Gets the dictionary of objects stored in this JSONStorage instance.
        /// </summary>
        public Dictionary<string, BaseClass> objects { get; private set; } = new Dictionary<string, BaseClass>();

        /// <summary>
        /// Returns the dictionary of objects stored in this JSONStorage instance.
        /// </summary>
        /// <returns>The dictionary of objects stored in this JSONStorage instance.</returns>
        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        /// <summary>
        /// Adds a new object to the JSONStorage instance.
        /// </summary>
        /// <param name="obj">The object to add.</param>
        public void New(BaseClass obj)
        {
            objects[$"{obj.GetType().Name}.{obj.id}"] = obj;
        }

        /// <summary>
        /// Serializes the objects stored in this JSONStorage instance to a JSON file and saves it.
        /// </summary>
        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(objects, options);
            Directory.CreateDirectory("storage");
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Deserializes the JSON file saved and loads the objects into this JSONStorage instance.
        /// </summary>
        public void Load()
        {
            if (File.Exists(_filePath))
            {
                string jsonString = File.ReadAllText(_filePath);
                objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
            }
        }
    }
}
