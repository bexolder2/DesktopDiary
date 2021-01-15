using System.Windows;
using System.Windows.Controls;

namespace DesctopDiary.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel.MainWindowViewModel();
        }
        //TODO:Setter
    }
}
