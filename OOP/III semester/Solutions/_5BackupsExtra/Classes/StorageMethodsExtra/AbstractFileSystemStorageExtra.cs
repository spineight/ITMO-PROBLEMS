using System.Collections.Generic;
using Backups.Classes.RestorePoints;
using Backups.Classes.StorageMethods;
using Backups.Classes.Storages;

namespace BackupsExtra.Classes.StorageMethodsExtra
{
    public class AbstractFileSystemStorageExtra : AbstractFileSystemStorage, IStorageExtraMethod
    {
        public void RemoveRestorePoint(RestorePoint restorePoint)
        {
            foreach (Storage storage in restorePoint.PublicStorages)
            {
                RemoveFile(storage.FullPath);
            }

            RemoveDirectory(restorePoint.FullPath);
        }

        public IEnumerable<Storage> Merge(RestorePoint lastVersion, RestorePoint newVersion)
        {
            var newVersionNames = new HashSet<string>();
            foreach (Storage storage in newVersion.PublicStorages)
            {
                newVersionNames.Add(storage.Name);
            }

            var addedStorages = new LinkedList<Storage>();
            foreach (Storage lastStorage in lastVersion.PublicStorages)
            {
                if (newVersionNames.Contains(lastStorage.Name)) continue;

                var updatedStorage = new Storage(lastStorage.Name, newVersion.FullPath, lastStorage.JobObjects);
                Move(lastStorage.FullPath, updatedStorage.FullPath);
                addedStorages.AddFirst(updatedStorage);
            }

            RemoveRestorePoint(lastVersion);
            return addedStorages;
        }

        public void Move(string from, string too)
        {
            PathFiles.Remove(from);
            PathFiles.Add(too);
        }

        public void Recover(string from, string too)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveDirectory(string path)
        {
            PathDirectories.Remove(path);
        }

        public void RemoveFile(string path)
        {
            PathFiles.Remove(path);
        }
    }
}