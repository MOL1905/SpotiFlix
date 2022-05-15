using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpotiFlix
{
    internal class FileHandling
    {
        public void SaveData<T>(string file, T data)
        {
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(file, json);
        }
        public T? LoadData <T>(string file)
        {
            string load = File.ReadAllText(file);
            T? data = JsonSerializer.Deserialize<T>(load);
            return data;
        }

    }
}
