using GuidGenerator.Interfaces;

namespace GuidGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IMainWindow
    {
        public MainWindow(IWindowContext context)
        {
            InitializeComponent();
            DataContext = context;
        }
    }
}
