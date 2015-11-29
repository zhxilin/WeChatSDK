using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Storage;

namespace MicroMsg.sdk.utils
{
    public class FileUtil
    {
        
        public async static void AppendToFile(string fileName, string folderName, byte[] data)
        {
            try
            {
                var folder = await ApplicationData.Current.LocalFolder.CreateFolderAsync(folderName, CreationCollisionOption.OpenIfExists);
                var file = await folder.GetFileAsync(fileName);
                if (file != null)
                {
                    using (var fileStream = await file.OpenStreamForWriteAsync())
                    {
                        fileStream.Seek(0L, SeekOrigin.End);
                        fileStream.Write(data, 0, data.Length);
                    }
                }

            }
            catch (Exception)
            {
                // ignored
            }
        }

        public async static Task<bool> CreateDir(string strPath)
        {
            if (!string.IsNullOrEmpty(strPath))
            {
                try
                {
                    await ApplicationData.Current.LocalFolder.CreateFolderAsync(strPath);

                    return true;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return false;
        }

        public async static void DeleteDir(StorageFile isf, string path, bool bDeleteDir = true)
        {
            var folder = await ApplicationData.Current.LocalFolder.GetFolderAsync(path);
            var files = await folder.GetFilesAsync();
            foreach (var file in files)
            {
                await file.DeleteAsync(StorageDeleteOption.PermanentDelete);
            }
            if (bDeleteDir)
            {
                await folder.DeleteAsync();
            }

        }

        public async static Task<bool> DeleteFile(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    var file = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);

                    if (file != null)
                    {
                        await file.DeleteAsync();

                        return true;
                    }


                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return false;
        }

        public async static Task<bool> DirExists(string path)
        {
            try
            {
                var folder = await ApplicationData.Current.LocalFolder.GetFolderAsync(path);
                return folder != null;
            }
            catch (Exception)
            {
                // ignored
            }
            return false;
        }

        public static bool EmptyDir(string strPath)
        {
            if (!string.IsNullOrEmpty(strPath))
            {
                try
                {
                    //using (IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForApplication())
                    //{
                    //    if (!file.DirectoryExists(strPath))
                    //    {
                    //        return false;
                    //    }
                    //    foreach (string str in file.GetFileNames(strPath + "/*"))
                    //    {
                    //        file.DeleteFile(strPath + "/" + str);
                    //    }
                    //    foreach (string str2 in file.GetDirectoryNames(strPath + "/*"))
                    //    {
                    //        deleteDir(file, strPath + "/" + str2, true);
                    //    }
                    //}
                    return true;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return false;
        }

        public static bool EmptyFile(string strPath)
        {
            if (!string.IsNullOrEmpty(strPath))
            {
                try
                {
                    //using (IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForApplication())
                    //{
                    //    if (!file.DirectoryExists(strPath))
                    //    {
                    //        return false;
                    //    }
                    //    deleteDir(file, strPath, false);
                    //}
                    return true;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return false;
        }

        public async static Task<bool> FileExists(string path)
        {
            try
            {
                var regex = new Regex(@"(\w*)[\\\/](\w*.\w*)*");
                var matches = regex.Matches(path);
                if (matches == null || matches.Count == 0)
                {
                    return false;
                }
                var foldername = matches[0].Groups[1].Value;
                var filename = matches[0].Groups[2].Value;

                var folder = await ApplicationData.Current.LocalFolder.GetFolderAsync(foldername);

                var file = await folder.GetFileAsync(filename);
                return file != null;
            }
            catch (Exception)
            {
                // ignored
            }
            return false;
        }

        public async static Task<long> FileLength(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    var file = await ApplicationData.Current.LocalFolder.GetFileAsync(path);
                    using (var fileStream = await file.OpenAsync(FileAccessMode.ReadWrite))
                    {
                        return (long)fileStream.Size;
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return 0L;
        }

        public async static Task<long> GetFileExistTime(string path)
        {
            try
            {
                var file = await ApplicationData.Current.LocalFolder.GetFileAsync(path);
                if (file != null)
                {
                    var date = file.DateCreated;
                    return (long)DateTime.Now.Subtract(date.Date).TotalSeconds;
                }
            }
            catch (Exception)
            {
                // ignored
            }
            return 0L;
        }

        public async static Task<byte[]> ReadFromFile(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    var file = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                    if (file == null) return null;

                    using (var fileStream = await file.OpenReadAsync())
                    {
                        Stream stream = fileStream.GetInputStreamAt(0).AsStreamForRead();

                        byte[] buffer = new byte[stream.Length];

                        using (MemoryStream ms = new MemoryStream())
                        {
                            int read;
                            while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                ms.Write(buffer, 0, read);
                            }
                            return ms.ToArray();
                        }

                    }

                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return null;
        }

        public async static Task<byte[]> ReadFromFile(string path, int offset, int count)
        {
            try
            {
                var regex = new Regex(@"(\w*)[\\\/](\w*.\w*)*");
                var matches = regex.Matches(path);
                if (matches == null || matches.Count == 0)
                {
                    return null;
                }
                var foldername = matches[0].Groups[1].Value;
                var filename = matches[0].Groups[2].Value;

                var folder = await ApplicationData.Current.LocalFolder.GetFolderAsync(foldername);

                var file = await folder.GetFileAsync(filename);

                using (var fileStream = await file.OpenStreamForReadAsync())
                {

                    fileStream.Seek(offset, SeekOrigin.Begin);
                    byte[] buffer = new byte[count];
                    if (fileStream.Read(buffer, 0, buffer.Length) != count)
                    {
                        return null;
                    }
                    return buffer;

                }
            }
            catch (Exception)
            {
                // ignored
            }
            return null;
        }

        public async static Task<bool> WriteToFile(string fileName, string folderName, byte[] data, bool bCreateDir = false)
        {
            if (!string.IsNullOrEmpty(fileName) && (data != null))
            {
                try
                {
                    var folder = await ApplicationData.Current.LocalFolder.CreateFolderAsync(folderName, CreationCollisionOption.OpenIfExists);
                    var file = await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);

                    using (var fileStream = await file.OpenStreamForWriteAsync())
                    {
                        fileStream.Position = 0;
                        fileStream.Write(data, 0, data.Length);
                    }
                    return true;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return false;
        }
    }








}
