using System;
using System.Collections.Generic;
using System.Windows.Input;
using DesctopDiary.View;
using DesctopDiary.Infrastructure.Commands;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;

namespace DesctopDiary.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public Dictionary<Data.Task, DateTime> Tasks; //TODO: add data

        private ObservableCollection<Page> _pages;
        public ObservableCollection<Page> Pages
        {
            get => _pages;
            private set => Set(ref _pages, value);
        }

        private DisplayState _displayState;
        public DisplayState displayState
        {
            get => _displayState;
            private set => Set(ref _displayState, value);
        }
       
        public MainWindowViewModel()
        {
            displayState = DisplayState.Month;
            //TODO:Serialize display state
            Tasks = new Dictionary<Data.Task, DateTime>();
            InitializePagesCollection();
            DisplayDayCommand = new LambdaCommand(OnDisplayDayCommandExecuted, CanDisplayDayCommandExecute);
            DisplayWeekCommand = new LambdaCommand(OnDisplayWeekCommandExecuted, CanDisplayWeekCommandExecute);
            DisplayMonthCommand = new LambdaCommand(OnDisplayMonthCommandExecuted, CanDisplayMonthCommandExecute);
            EditCommand = new LambdaCommand(OnEditCommandExecuted, CanEditCommandExecute);
        }

        private void InitializePagesCollection()
        {
            Pages = new ObservableCollection<Page>();
            AddPage(new Day());
            AddPage(new Week());
            AddPage(new Month());
        }

        private void AddPage(Page p)
        {
            Page tempPage = p;
            Pages.Add(tempPage);
        }

        #region commands
        public ICommand DisplayDayCommand { get; private set; }
        private bool CanDisplayDayCommandExecute(object p) => true;

        private void OnDisplayDayCommandExecuted(object p)
        {
            displayState = DisplayState.Day; //TODO: add data to new page

        }

        public ICommand DisplayWeekCommand { get; private set; }
        private bool CanDisplayWeekCommandExecute(object p) => true;

        private void OnDisplayWeekCommandExecuted(object p)
        {
            displayState = DisplayState.Week;
        }

        public ICommand DisplayMonthCommand { get; private set; }
        private bool CanDisplayMonthCommandExecute(object p) => true;

        private void OnDisplayMonthCommandExecuted(object p)
        {
            displayState = DisplayState.Month;
        }

        public ICommand NextPageCommand { get; private set; }
        private bool CanNextPageCommandExecute(object p) => true;

        private void OnNextPageCommandExecuted(object p)
        {
            //TODO: next navigation
        }

        public ICommand PreviousPageCommand { get; private set; }
        private bool CanPreviousPageCommandExecute(object p) => true;

        private void OnPreviousPageCommandExecuted(object p)
        {
            //TODO: previous navigation
        }

        public ICommand EditCommand { get; private set; }
        private bool CanEditCommandExecute(object p) => true;

        private void OnEditCommandExecuted(object p)
        {
            //TODO: edit logic
            EditTaskWindow etw = new EditTaskWindow();
            etw.Show();
            MessageBox.Show("OnEditCommandExecuted");
        }
        #endregion
    }
}
