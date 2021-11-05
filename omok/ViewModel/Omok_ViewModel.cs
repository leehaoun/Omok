using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Games
{   public class items
    {
        public int num { get; set; }
        public int row { get; set; }
        public int col { get; set; }
    }
    class Omok_ViewModel:ObservableObject
    {
        public Omok_ViewModel()
        {
            for (int i = 0; i < 100; i++)
                array100.Add(new items(){ num=i });
        }

        private ObservableCollection<items> array100 = new ObservableCollection<items>();
        public ObservableCollection<items> Array100
        {
            get
            {
                return array100;
            }
            set
            {
                SetProperty(ref array100, value);
            }
        }

        private Uri[] img_uri = new Uri[100];
        public Uri[] Img_uri
        {
            get
            {
                return img_uri;
            }
            set
            {
                SetProperty(ref img_uri, value);
            }
        }

        public ICommand LeftClick
        {
            get => new RelayCommand<int>((x) =>
            {
                Img_uri[x] = new Uri("pack://application:,,/Resource/black.png");
                RaisePropertyChanged("Img_uri");
            });
        }
        public ICommand RightClick
        {
            get => new RelayCommand<int>((x) =>
            {
                Img_uri[x] = new Uri("pack://application:,,/Resource/white.png");
                RaisePropertyChanged("Img_uri");
            });
        }
    }
}
