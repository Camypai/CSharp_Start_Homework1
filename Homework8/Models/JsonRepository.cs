using System.Collections.Generic;
using System.Linq;
using HomeworkFileLibrary;
using Newtonsoft.Json;

namespace Homework8.Models
{
    internal class JsonRepository<T> where T : BaseModel
    {
        private readonly string _path;

        public JsonRepository(string path, bool open = false)
        {
            _path = path;
            if(!open)
            Create(new List<T>());
        }

        public bool Create(List<T> item)
        {
            var result = JsonConvert.SerializeObject(item);

            return FileHelper.WriteFile(_path, result);
        }

        public T Get(int id)
        {
            var allData = JsonConvert.DeserializeObject<List<T>>(FileHelper.GetFile(_path));
            return allData.FirstOrDefault(q => q.Id == id);
        }

        public List<T> Get()
        {
            var result = JsonConvert.DeserializeObject<List<T>>(FileHelper.GetFile(_path));

            return result ?? new List<T>();
        }
    }
}
