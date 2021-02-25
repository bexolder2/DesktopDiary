using System;
using System.Windows;
using DesktopDiary.View;

namespace DesktopDiary.Services
{
    public class DialogManager : IDialogService
    {
        private EditTaskWindow EditWindow { get; set; }

        public DialogManager()
        {
            EditWindow = new EditTaskWindow();
        }

        public object ReturnValues(object data)
        {
            return data;
        }

        private void ShowDialog<T>(T dialog) where T : Window
        {
            dialog.Show();
        }

        private void DestroyDialog<T>(T dialog) where T : Window
        {
            dialog.Close();
        }

        public void ShowManager(string parameter)
        {
            switch (parameter)
            {
                case "edit":
                    ShowDialog(EditWindow);
                    break;
                default:
                    break;
            }
        }

        public void CloseManager(string parameter)
        {
            switch (parameter)
            {
                case "edit":
                    DestroyDialog(EditWindow);
                    break;
                default:
                    break;
            }
        }
    }
}
