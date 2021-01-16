using System;
using System.Collections.Generic;
using System.ComponentModel;
using DesctopDiary.View;

namespace DesctopDiary.Data
{
    public class Task // : INotifyPropertyChanged
    {
        public string task { get; private set; }
        public DateTime Date { get; private set; }
        public ViewModel.StatusColor statusColor { get; private set; }

        public Task(string taskInfo, DateTime selectedDate, ViewModel.StatusColor sc)
        {
            task = taskInfo;
            Date = selectedDate;
            statusColor = sc;
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
