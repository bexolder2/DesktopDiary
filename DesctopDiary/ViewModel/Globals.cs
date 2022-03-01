using DesktopDiary.Services;

namespace DesktopDiary.ViewModel
{
    public enum Days
    {
        MON,
        TUE,
        WED,
        THU,
        FRI,
        SAT,
        SUN
    }

    public enum DisplayState
    {
        Day,
        Week,
        Month
    }

    public enum StatusColor
    {
        Blue,
        Green,
        Orange
    }

    public static class Globals
    {
        public static DisplayState displayState;
        public static DialogManager Manager = new DialogManager();
        public static DateManager dateManager = new DateManager();
    }
}
