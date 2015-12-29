using System;
using System.ComponentModel;
using System.Windows.Input;

namespace GuidGenerator.Interfaces
{
    public interface IWindowContext : INotifyPropertyChanged
    {
        ICommand CopyCommand { get; }
        ICommand CopyNewCommand { get; }
        ICommand CreateNewCommand { get; }
        Guid CurrentGuid { get; }
    }
}