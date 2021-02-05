using System;
using System.Collections.Generic;
using System.ComponentModel;
using DesktopDiary.View;

namespace DesktopDiary.Data
{
    public class Task : ViewModel.BaseViewModel// : INotifyPropertyChanged
    {
        private string _task;
        private DateTime _date;
        private ViewModel.StatusColor _statusColor;

        public Task()
        {

        }

        public Task(string taskInfo, DateTime selectedDate, ViewModel.StatusColor sc)
        {
            task = taskInfo;
            Date = selectedDate;
            statusColor = sc;
        }

        public string task
        {
            get => _task;
            set => Set(ref _task, value);
        }

        public DateTime Date
        {
            get => _date;
            set => Set(ref _date, value);
        }

        public ViewModel.StatusColor statusColor
        {
            get => _statusColor;
            set => Set(ref _statusColor, value);
        }
        //public void SetProperties<T>(T property)
        //{

        //}

        #region
        //private string _task;
        //public string task
        //{
        //    get { return _task; }
        //    set
        //    {
        //        _task = value;
        //        OnPropertyChanged(_task);
        //    }
        //}
        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged(string propName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        //}
        #endregion
    }
}
