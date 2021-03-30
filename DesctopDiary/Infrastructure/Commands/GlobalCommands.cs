using DesktopDiary.ViewModel;
using System.Windows.Input;

namespace DesktopDiary.Infrastructure.Commands
{
    public class GlobalCommands
    {
        public GlobalCommands()
        {
            NewTaskCommand = new LambdaCommand(OnNewTaskCommandExecuted, CanNewTaskCommandExecute);
        }

        #region command for views(day, week, month)
        public ICommand NewTaskCommand { get; private set; }
        private bool CanNewTaskCommandExecute(object p) => true;

        private void OnNewTaskCommandExecuted(object p)
        {
            Globals.Manager.ShowManager("edit");
            //TODO: return values
            //TODO: save date
        }
        #endregion
    }
}
