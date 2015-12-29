using System;
using System.ComponentModel;
using System.Windows.Input;
using GuidGenerator.Interfaces;

namespace GuidGenerator
{
    public class WindowContext : IWindowContext
    {
        #region Variables

        private readonly IGuidWorker _context;

        #endregion Variables

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        public ICommand CopyCommand => new RelayCommand(param => _context.CopyCurrentGuid());

        public ICommand CopyNewCommand => new RelayCommand(param => _context.CopyNewGuid());

        public ICommand CreateNewCommand => new RelayCommand(param => _context.GenerateNewGuid());

        public Guid CurrentGuid { get; private set; }

        #endregion Properties

        #region Constructor

        public WindowContext(IGuidWorker guidWorker)
        {
            _context = guidWorker;
            _context.PropertyChanged += (sender, args) =>
            {
                CurrentGuid = _context.CurrentGuid;
            };
            CurrentGuid = _context.CurrentGuid;
        }

        #endregion Constructor
    }
}