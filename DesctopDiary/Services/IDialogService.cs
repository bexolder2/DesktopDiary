using System.Collections.Generic;
using System.Windows;

namespace DesktopDiary.Services
{
    public interface IDialogService
    {
        //void ShowDialog<T>(T dialog) where T : Window;
        void SetReturnValues<T>(object data);
        object GetReturnValues();
    }
}
