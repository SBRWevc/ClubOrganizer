using ClubOrganizer._01_Model;
using ClubOrganizer._04_Commands;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ClubOrganizer._02_ModelView.Pages.Configuration
{
    class ViewModelCreatePositions : INotifyPropertyChanged
    {
        private string _position;
        public string Position
        {
            get { return _position; }
            set
            {
                _position = value;
                OnPropertyChanged(nameof(Position));
            }
        }

        #region Colletions

        public ObservableCollection<PositionButtonModel> Positions { get; set; }

        #endregion

        #region ContractsRoots

        private bool _readContract;
        public bool ReadContract
        {
            get { return _readContract; }
            set
            {
                _readContract = value;
                OnPropertyChanged(nameof(ReadContract));
            }
        }
        private bool _writeContract;
        public bool WriteContract
        {
            get { return _writeContract; }
            set
            {
                _writeContract = value;
                OnPropertyChanged(nameof(WriteContract));
            }
        }
        private bool _changeContract;
        public bool ChangeContract
        {
            get { return _changeContract; }
            set
            {
                _changeContract = value;
                OnPropertyChanged(nameof(ChangeContract));
            }
        }

        #endregion

        #region ServicesRoots

        private bool _readService;
        public bool ReadService
        {
            get { return _readService; }
            set
            {
                _readService = value;
                OnPropertyChanged(nameof(ReadService));
            }
        }
        private bool _writeService;
        public bool WriteService
        {
            get { return _writeService; }
            set
            {
                _writeService = value;
                OnPropertyChanged(nameof(WriteService));
            }
        }
        private bool _changeService;
        public bool ChangeService
        {
            get { return _changeService; }
            set
            {
                _changeService = value;
                OnPropertyChanged(nameof(ChangeService));
            }
        }

        #endregion

        #region UsersRoots

        private bool _readUser;
        public bool ReadUser
        {
            get { return _readUser; }
            set
            {
                _readUser = value;
                OnPropertyChanged(nameof(ReadUser));
            }
        }
        private bool _writeUser;
        public bool WriteUser
        {
            get { return _writeUser; }
            set
            {
                _writeUser = value;
                OnPropertyChanged(nameof(WriteUser));
            }
        }
        private bool _changeUser;
        public bool ChangeUser
        {
            get { return _changeUser; }
            set
            {
                _changeUser = value;
                OnPropertyChanged(nameof(ChangeUser));
            }
        }

        #endregion

        #region PagesRoots

        private bool _main;
        public bool Main
        {
            get { return _main; }
            set
            {
                _main = value;
                OnPropertyChanged(nameof(Main));
            }
        }
        private bool _timetable;
        public bool Timetable
        {
            get { return _timetable; }
            set
            {
                _timetable = value;
                OnPropertyChanged(nameof(Timetable));
            }
        }
        private bool _contracts;
        public bool Contracts
        {
            get { return _contracts; }
            set
            {
                _contracts = value;
                OnPropertyChanged(nameof(Contracts));
            }
        }
        private bool _services;
        public bool Services
        {
            get { return _services; }
            set
            {
                _services = value;
                OnPropertyChanged(nameof(Services));
            }
        }
        private bool _payments;
        public bool Payments
        {
            get { return _payments; }
            set
            {
                _payments = value;
                OnPropertyChanged(nameof(Payments));
            }
        }
        private bool _reports;
        public bool Reports
        {
            get { return _reports; }
            set
            {
                _reports = value;
                OnPropertyChanged(nameof(Reports));
            }
        }
        private bool _clients;
        public bool Clients
        {
            get { return _clients; }
            set
            {
                _clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }
        private bool _blacklist;
        public bool Blacklist
        {
            get { return _blacklist; }
            set
            {
                _blacklist = value;
                OnPropertyChanged(nameof(Blacklist));
            }
        }
        private bool _settings;
        public bool Settings
        {
            get { return _settings; }
            set
            {
                _settings = value;
                OnPropertyChanged(nameof(Settings));
            }
        }
        private bool _chat;
        public bool Chat
        {
            get { return _chat; }
            set
            {
                _chat = value;
                OnPropertyChanged(nameof(Chat));
            }
        }

        #endregion

        #region Voids

        private void CheckDev()
        {
            ReadContract = true;
            WriteContract = true;
            ChangeContract = true;

            ReadService = true;
            WriteService = true;
            ChangeService = true;

            ReadUser = true;
            WriteUser = true;
            ChangeUser = true;

            Main = true;
            Timetable = true;
            Contracts = true;
            Services = true;
            Payments = true;
            Reports = true;
            Clients = true;
            Blacklist = true;
            Settings = true;
            Chat = true;

            Position = "Разработчик";
        }

        #endregion

        public ViewModelCreatePositions()
        {
            Positions = new()
            {
                new PositionButtonModel { PositionName = "Разработчик", PositionCommand = new RelayCommand(CheckDev) }
            };
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
