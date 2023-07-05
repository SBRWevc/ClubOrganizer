using ClubOrganizer._02_ModelView.Pages.Configuration;
using ClubOrganizer._03_View.Pages.Configuration;
using ClubOrganizer._04_Commands;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClubOrganizer._02_ModelView
{
    class ViewModelConfiguration : INotifyPropertyChanged
    {
        #region Pages

        readonly Page Page1 = new PageWelcome();
        readonly Page Page2 = new PageCreatePositions();
        readonly Page Page3 = new PageCreateUser();

        private Page _currentPage;
        public Page CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        #endregion

        #region Commands

        private ICommand _nextPageCommand;
        public ICommand NextPageCommand
        {
            get { return _nextPageCommand; }
            set
            {
                _nextPageCommand = value;
                OnPropertyChanged(nameof(NextPageCommand));
            }
        }        

        private ICommand _backPageCommand;
        public ICommand BackPageCommand
        {
            get { return _backPageCommand; }
            set
            {
                _backPageCommand = value;
                OnPropertyChanged(nameof(BackPageCommand));
            }
        }        

        #endregion

        #region Voids

        private void NextPage()
        {
            if (CurrentPage == Page1)
            {
                CurrentPage = Page2;
            }
            else if (CurrentPage == Page2)
            {
                CurrentPage = Page3;
            }

        }
        private void BackPage()
        {
            if (CurrentPage == Page2)
            {
                CurrentPage = Page1;
            }
            else if (CurrentPage == Page3)
            {
                CurrentPage = Page2;
            }
        }

        #endregion

        public ViewModelConfiguration()
        {
            NextPageCommand = new RelayCommand(NextPage);
            BackPageCommand = new RelayCommand(BackPage);

            CurrentPage = Page1;
        }

        #region PropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
