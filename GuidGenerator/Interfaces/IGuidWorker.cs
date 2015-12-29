using System;
using System.ComponentModel;

namespace GuidGenerator.Interfaces
{
    public interface IGuidWorker : INotifyPropertyChanged
    {
        Guid CurrentGuid { get; set; }
        void GenerateNewGuid();
        void CopyCurrentGuid();
        void CopyNewGuid();
    }
}