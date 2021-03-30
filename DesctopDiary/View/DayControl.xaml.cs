using System;
using System.Windows.Controls;

namespace DesktopDiary.View
{
    /// <summary>
    /// Interaction logic for DayControl.xaml
    /// </summary>
    public partial class DayControl : UserControl
    {
        private ViewModel.DayControlViewModel _dcvm = new ViewModel.DayControlViewModel();

        public DayControl()
        {
            InitializeComponent(); 
            DataContext = _dcvm;
        }

        public void DayUpdater(double multiplier)
        {
            _dcvm.DayUpdater(multiplier);
        }

        public DateTime GetDate()
        {
            return _dcvm.DayDate;
        }
    }
}
