using APalavraDeDeus.Helpers;
using APalavraDeDeus.Services.Interfaces;
using BibliaRegex.Models;
using System.Threading.Tasks;

namespace APalavraDeDeus.Services
{
    /// <summary>
    /// The repository for the bible.
    /// </summary>
    public class BibleRepository : IBibleRepository
    {
        #region Methods

        #region Public

        /// <summary>
        /// Load the Bible named of: "Almeida Revista e Atualizada".
        /// </summary>
        /// <returns>The ARA Bible in Portuguese from Brazil.</returns>
        public async Task<Bible> GetBible()
        {
            string bibleJsonFile = string.Format(ImportantPath.JsonFilePathFormat, "ARA");

            return await FileReaderService.LoadObjectFromJsonFile<Bible>(bibleJsonFile);
        }

        #endregion

        #endregion
    }
}