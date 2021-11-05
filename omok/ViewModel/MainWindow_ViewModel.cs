using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Games
{
    public class MainWindow_ViewModel : ObservableObject
    {
        public MainWindow_ViewModel()
        {
            Omok om = new Omok();
            omokpanel = om;
        }
        private UserControl omokpanel;
        public UserControl OmokPanel
        {
            get
            {
                return omokpanel;
            }
            set
            {
                SetProperty(ref omokpanel, value);
            }
        }
    }
}
