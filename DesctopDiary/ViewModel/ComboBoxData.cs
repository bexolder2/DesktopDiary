using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;

namespace DesctopDiary.ViewModel
{
    public class ComboBoxData : BaseViewModel
    {
        private Brush _labelsColor;
        private string _textConst;

        public Brush LabelsColor
        {
            get => _labelsColor;
            private set => Set(ref _labelsColor, value);
        }

        public string TextConst
        {
            get => _textConst;
            private set => Set(ref _textConst, value);
        }

        public ComboBoxData(string HEXcolor, string text) 
        {
            var converter = new BrushConverter();
            LabelsColor = (Brush)converter.ConvertFromString(HEXcolor);
            TextConst = text;
        }
    }
}