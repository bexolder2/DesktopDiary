using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using DesctopDiary.Infrastructure.Commands;

namespace DesctopDiary.ViewModel
{
    public class EditTaskWindowViewModel : BaseViewModel
    {
        private List<ComboBoxData> _cbData;
        private ComboBoxData _cbSolo;

        private Data.Task _task;

        public Data.Task TmpTask
        {
            get => _task;
            set => Set(ref _task, value);
        }

        public ComboBoxData cbSolo
        {
            get => _cbSolo;
            set => Set(ref _cbSolo, value);
        }

        public List<ComboBoxData> CBData
        {
            get => _cbData;
            set => Set(ref _cbData, value);
        }

        public EditTaskWindowViewModel()
        {
            TmpTask = new Data.Task();

            SaveCommand = new LambdaCommand(OnSaveCommandExecuted, CanSaveCommandExecute);
            CancelCommand = new LambdaCommand(OnCancelCommandExecuted, CanCancelCommandExecute);

            CBData = new List<ComboBoxData>();
            InitializecbData("#0094cc", "Will definitely happen"); //  0, 148, 204
            InitializecbData("#00b248", "Need to do"); //   0, 178, 72
            InitializecbData("#f9a825", "It is desirable to do"); //   249, 168, 37
        }

        private void InitializecbData(string HEX, string text)
        {
            cbSolo = new ComboBoxData(HEX, text);
            CBData.Add(cbSolo);
        }


        #region commands
        public ICommand SaveCommand { get; private set; }
        private bool CanSaveCommandExecute(object p) => true; //TODO: check fields

        private void OnSaveCommandExecuted(object p)
        {
            MessageBox.Show($"{TmpTask.task} + {cbSolo.TextConst}");
            //TODO: save date to TmpTask
            //TODO: save logic
        }

        public ICommand CancelCommand { get; private set; }
        private bool CanCancelCommandExecute(object p) => true;

        private void OnCancelCommandExecuted(object p)
        {
            foreach(Window own in Application.Current.MainWindow.OwnedWindows)
            {
                if (own.IsActive)
                    own.Close();
            }
            //Application.Current.MainWindow.OwnedWindows[0].Close();
        }
        #endregion
    }
}