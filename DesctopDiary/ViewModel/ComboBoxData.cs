using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;

namespace DesctopDiary.ViewModel
{
    public class ComboBoxData : BaseViewModel
    {
        private Color _labelsColor;
        private string _textConst;

        public Color LabelsColor
        {
            get => _labelsColor;
            private set => Set(ref _labelsColor, value);
        }

        public string TextConst
        {
            get => _textConst;
            private set => Set(ref _textConst, value);
        }

        public ComboBoxData(string text) //Color color, 
        {
            LabelsColor = Colors.Red;
            TextConst = text;
        }
    }
}