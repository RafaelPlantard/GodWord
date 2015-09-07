using Prism.Mvvm;

namespace APalavraDeDeus.Models
{
    /// <summary>
    /// Represents a reference for a verse in the bible.
    /// </summary>
    public class VerseReference : BindableBase
    {
        #region Fields

        private string _notes;
        private string _reference;

        #endregion

        #region Properties

        /// <summary>
        /// Notes for this reference.
        /// </summary>
        public string Notes
        {
            get { return _notes; }
            set { SetProperty(ref _notes, value); }
        }

        /// <summary>
        /// A verse reference.
        /// </summary>
        public string Reference
        {
            get { return _reference; }
            set { SetProperty(ref _reference, value); }
        }

        #endregion
    }
}