using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace APalavraDeDeus.Models
{
    /// <summary>
    /// A bookmark for bible.
    /// </summary>
    public class Bookmark : BindableBase
    {
        #region Fields

        private DateTime _dateCreated;
        private string _responsible;
        private string _title;
        private ObservableCollection<VerseReference> _verses;

        #endregion

        #region Properties

        /// <summary>
        /// The date of this favorite was created.
        /// </summary>
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { SetProperty(ref _dateCreated, value); }
        }

        /// <summary>
        /// The responsible for the favorite, case of a sermon.
        /// </summary>
        public string Responsible
        {
            get { return _responsible; }
            set { SetProperty(ref _responsible, value); }
        }

        /// <summary>
        /// The title of this favorite.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        /// <summary>
        /// The verses that contains this bookmarks.
        /// </summary>
        public ObservableCollection<VerseReference> Verses
        {
            get { return _verses; }
            set { SetProperty(ref _verses, value); }
        }

        #endregion
    }
}
