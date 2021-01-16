using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesctopDiary.ViewModel
{
    public class EditTaskWindowViewModel : BaseViewModel
    {
        private List<ComboBoxData> _cbData;
        private ComboBoxData _cbSolo;

        public ComboBoxData cbSolo
        {
            get => _cbSolo;
            set => Set(ref _cbSolo, value);
        }

        public List<ComboBoxData> CBData
        {
            get => _cbData;
            set => Set(ref _cbData, value);
        }

        public EditTaskWindowViewModel()
        {
            CBData = new List<ComboBoxData>();
            InitializecbData(0, 148, 204, "Will definitely happen"); //#0094cc
            InitializecbData(0, 178, 72, "Need to do"); //#00b248
            InitializecbData(249, 168, 37, "It is desirable to do"); //#f9a825
        }

        private void InitializecbData(byte r, byte g, byte b, string text)
        {
            Color tmpColor = new Color();
            tmpColor.G = g;
            tmpColor.R = r;
            tmpColor.B = b;
            SolidColorBrush tmpSolidBrush = new SolidColorBrush(tmpColor);
            //Brush tmpBrush = tmpSolidBrush;
            cbSolo = new ComboBoxData(text);
            CBData.Add(cbSolo);
        }
    }
}