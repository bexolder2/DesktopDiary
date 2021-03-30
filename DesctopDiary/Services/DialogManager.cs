using System;
using System.Collections.Generic;
using System.Windows;
using DesktopDiary.View;

namespace DesktopDiary.Services
{
    public class DialogManager : IDialogService
    {
        Dictionary<string, object> ReturnValues; //Key - View`s name
        List<DateTime> Dates;
        private EditTaskWindow EditWindow { get; set; }

        public DialogManager()
        {
            EditWindow = new EditTaskWindow();
            ReturnValues = new Dictionary<string, object>();
            Dates = new List<DateTime>();
        }

        public void SetReturnValues<T>(object data, string key)
        {
            ReturnValues.Add(key, data);
        }
        public object GetReturnValues(string key)
        {
            return ReturnValues[key];
        }
        private void ShowDialog<T>(T dialog) where T : Window
        {
            dialog.ShowDialog();
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

        public DateTime GetCurrentDate()
        {

            return DateTime.Now;
        }
    }
}
