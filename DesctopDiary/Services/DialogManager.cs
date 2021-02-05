using System;
using System.Windows;
using DesktopDiary.View;

namespace DesktopDiary.Services
{
    public class DialogManager : IDialogService
    {
        private EditTaskWindow EditWindow { get; set; }

        public object ReturnValues()
        {
            throw new NotImplementedException();
        }

        public void ShowDialog<T>(T dialog) where T : Window
        {
            dialog.Show();
        }


    }
}
