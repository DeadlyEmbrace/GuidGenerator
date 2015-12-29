using System.Windows;
using DryIoc;
using GuidGenerator.Interfaces;

namespace GuidGenerator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        #region Variables

        private Container _container;

        #endregion

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            SetupContainer();
            var mainWindow = _container.Resolve<IMainWindow>();
            mainWindow.Show();
        }

        private void SetupContainer()
        {
            _container = new Container();
            _container.Register<IMainWindow, MainWindow>();
            _container.Register<IWindowContext, WindowContext>();
            _container.Register<IGuidWorker, GuidWorker>();

            _container.VerifyResolutions();
        }
    }
}
