using BibliaRegex.Models;
using System.Threading.Tasks;

namespace APalavraDeDeus.Services.Interfaces
{
    /// <summary>
    /// The prototype for a repository of a Bible.
    /// </summary>
    public interface IBibleRepository
    {
        #region Methods

        /// <summary>
        /// Get the Bible.
        /// </summary>
        /// <returns>The found Bible.</returns>
        Task<Bible> GetBible();

        #endregion
    }
}
