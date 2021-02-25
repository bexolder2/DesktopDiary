using System.Windows;

namespace DesktopDiary.Services
{
    public interface IDialogService
    {
        //void ShowDialog<T>(T dialog) where T : Window;
        object ReturnValues(object data);
    }
}
