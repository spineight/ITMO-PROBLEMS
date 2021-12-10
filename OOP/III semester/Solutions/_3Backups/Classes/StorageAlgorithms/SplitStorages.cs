using System.Collections.Generic;
using System.IO;
using Backups.Classes.JobObjects;
using Backups.Classes.StorageMethods;
using Backups.Classes.Storages;

namespace Backups.Classes.StorageAlgorithms
{
    public class SplitStorages : IStorageAlgorithm
    {
        public List<Storage> CreateStorages(string path, IEnumerable<IJobObject> objects, IStorageMethod storageMethod)
        {
            var list = new List<Storage>();

            foreach (IJobObject jobObject in objects)
            {
                string fileName = Path.GetFileNameWithoutExtension(jobObject.Path);
                var storage = new Storage(fileName + ".zip", path, new List<IJobObject> { jobObject });
                storageMethod.Archive(storage);
                list.Add(storage);
            }

            return list;
        }
    }
}