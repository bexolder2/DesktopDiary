using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopDiary.ViewModel
{
    public class DayControlViewModel : BaseViewModel
    {
        private DateTime _dayDate;

        public DateTime DayDate
        {
            get => _dayDate;
            private set => Set(ref _dayDate, value);
        }

        public DayControlViewModel()
        {
            DayDate = DateTime.Now;
        }

        public void DayUpdater(double multiplier)
        {
            DayDate = Globals.dateManager.SetDate(DayDate, DayDate, multiplier);
        }
    }
}
