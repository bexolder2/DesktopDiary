using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopDiary.View
{
    public partial class Day : Page
    {
        public Day()
        {
            InitializeComponent();
            ViewModel.DayViewModel _dayVM = new ViewModel.DayViewModel();
            DataContext = _dayVM;
            ViewModel.Globals.dateManager.InitializeViewModels(_dayVM);
        }
    }
}
