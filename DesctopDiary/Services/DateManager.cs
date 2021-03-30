using DesktopDiary.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopDiary.Services
{
    public class DateManager : BaseViewModel
    {
        private DayViewModel _dvm;
        private WeekViewModel _wvm;
        private MonthViewModel _mvm;

        public DayViewModel DayVM
        {
            get => _dvm;
            private set => Set(ref _dvm, value);
        }

        public WeekViewModel WeekVM
        {
            get => _wvm;
            private set => Set(ref _wvm, value);
        }

        public MonthViewModel MonthVM
        {
            get => _mvm;
            private set => Set(ref _mvm, value);
        }

        public DateTime SetDate(DateTime receiver, DateTime startDate, double multiplier)
        {
            receiver = startDate.AddDays(multiplier);
            return receiver;
        }

        public void InitializeViewModels(object vm)
        {
            if(vm is DayViewModel)
            {
                DayVM = vm as DayViewModel;
            }
            else if(vm is WeekViewModel)
            {
                WeekVM = vm as WeekViewModel;
            }
            else  if(vm is MonthViewModel)
            {
                MonthVM = vm as MonthViewModel;
            }
            else
            {

            }
        }
    }
}
