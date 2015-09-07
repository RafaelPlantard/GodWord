using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Storage;

namespace APalavraDeDeus.Services
{
    /// <summary>
    /// A helper class that provides methods to read files.
    /// </summary>
    public class FileReaderService
    {
        #region Methods

        #region Public

        /// <summary>
        /// Help to get a file stored in the installed folder in a asynchronous way.
        /// </summary>
        /// <param name="path">File path.</param>
        /// <returns>A object of the type <see cref="StorageFile"/>.</returns>
        public static async Task<StorageFile> GetFileFromInstalledFolderAsync(string path)
        {
            return await Package.Current.InstalledLocation.GetFileAsync(path);
        }

        /// <summary>
        /// Read a file from the installed folder in a asynchronous way.
        /// </summary>
        /// <param name="path">File path.</param>
        /// <returns>The file content.</returns>
        public async static Task<string> ReadTextFileFromInstalledFolderAsync(string path)
        {
            StorageFile file = await GetFileFromInstalledFolderAsync(path);

            return await FileIO.ReadTextAsync(file);
        }

        /// <summary>
        /// Generic method to load data to object from a JSON file.
        /// </summary>
        /// <param name="jsonPath">The json path.</param>
        /// <returns>Returns the <see cref="Task"/> that indicates the task status.</returns>
        public static async Task<T> LoadObjectFromJsonFile<T>(string jsonPath)
        {
            string jsonFile = await ReadTextFileFromInstalledFolderAsync(jsonPath);

            return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(jsonFile));
        }

        #endregion

        #endregion
    }
}