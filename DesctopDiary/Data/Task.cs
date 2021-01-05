using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesctopDiary.Data
{
    public class Task : INotifyPropertyChanged
    {
        public string _task
        {
            get { return _task; }
            set
            {
                _task = value;
                OnPropertyChanged(_task);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
