using APalavraDeDeus.Services.Interfaces;
using BibliaRegex.Models;
using Prism.Commands;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace APalavraDeDeus.ViewModels
{
    /// <summary>
    /// The view model for the main page.
    /// </summary>
    public class MainPageViewModel : ViewModelBase
    {
        #region Fields

        private readonly IBibleRepository _bibleRepository;
        private ObservableCollection<Chapter> _chaptersToShow;
        private Book _selectedBook;
        private Chapter _selectedChapter;

        #endregion

        #region Properties

        /// <summary>
        /// A list of chapter of a specific book from the Bible.
        /// </summary>
        public ObservableCollection<Chapter> ChaptersToShow
        {
            get { return _chaptersToShow; }
            set { SetProperty(ref _chaptersToShow, value); }
        }

        /// <summary>
        /// The God's Word.
        /// </summary>
        public Task<Bible> GodWord
        {
            get { return _bibleRepository.GetBible(); }
        }

        /// <summary>
        /// The selected book from the Bible.
        /// </summary>
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set { SetProperty(ref _selectedBook, value); }
        }

        public Chapter SelectedChapter
        {
            get { return _selectedChapter; }
            set { SetProperty(ref _selectedChapter, value); }
        }

        #endregion

        #region Commands

        /// <summary>
        /// This command load a list of chapters of a specific book from the Bible.
        /// </summary>
        public ICommand LoadChaptersCommand { get; private set; }

        /// <summary>
        /// This command show the chapter that the user have selected.
        /// </summary>
        public ICommand ShowChapterCommand { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the services and commands.
        /// </summary>
        /// <param name="bibleRepository">A repository of <see cref="Bible"/>.</param>
        /// <param name="navigationService">A implementation of Navigation</param>
        public MainPageViewModel(IBibleRepository bibleRepository, INavigationService navigationService)
        {
            _bibleRepository = bibleRepository;

            LoadChaptersCommand = new DelegateCommand<Book>(LoadChapters);
            ShowChapterCommand = new DelegateCommand<Chapter>(ShowChapter);
        }

        #endregion

        #region Methods

        #region Private

        private void LoadChapters(Book book)
        {
            SelectedBook = book;

            ChaptersToShow = new ObservableCollection<Chapter>(book.Chapters);
        }

        private void ShowChapter(Chapter chapter)
        {
            SelectedChapter = chapter;
        }

        #endregion

        #endregion
    }
}
