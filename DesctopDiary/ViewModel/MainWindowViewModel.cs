using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesctopDiary.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public Dictionary<Data.Task, DateTime> Tasks;
       
        public MainWindowViewModel()
        {
            Tasks = new Dictionary<Data.Task, DateTime>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged(string propName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        //}
    }
}
