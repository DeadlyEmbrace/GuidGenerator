using System;
using System.ComponentModel;
using System.Windows;
using GuidGenerator.Interfaces;

namespace GuidGenerator
{
    public class GuidWorker : IGuidWorker
    {
        #region Properties

        public Guid CurrentGuid { get; set; }

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructor

        public GuidWorker()
        {
            CurrentGuid = Guid.NewGuid();
        }

        #endregion

        #region Public Methods

        public void GenerateNewGuid()
        {
            CurrentGuid = Guid.NewGuid();
        }

        public void CopyCurrentGuid()
        {
            Clipboard.SetText(CurrentGuid.ToString());
        }

        public void CopyNewGuid()
        {
            GenerateNewGuid();
            Clipboard.SetText(CurrentGuid.ToString());
        }

        #endregion
    }
}