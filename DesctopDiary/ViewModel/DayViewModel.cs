using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;
using System.Windows.Shapes;

namespace DesctopDiary.ViewModel
{
    public class DayViewModel : BaseViewModel
    {
        private DayOfWeek _currentDay;
        private DateTime _currentDate;


        public DayOfWeek CurrentDay
        {
            get => _currentDay;
            private set => Set(ref _currentDay, value);
        }

        public DateTime CurrentDate
        {
            get => _currentDate;
            private set => Set(ref _currentDate, value);
        }

        public DayViewModel()
        {
            CurrentDate = DateTime.Now;
            CurrentDay = DateTime.Now.DayOfWeek;
        }
    }
}
