using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using dbis_project.View_Model;
using System.ComponentModel;

namespace dbis_project.View
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
        public MainWindow()
        {
            VM = new ViewModel();

        }

        public enum MainWindowState
        {
            LogIn
        }

        public MainWindowState State
        {
            get
            {
                return state;
            }
            set
            {
                switch (value)
                {
                    case MainWindowState.LogIn:

                        break;
                    default:
                        break;
                }
            }
        }
        private MainWindowState state;


        public ObservableObject VM
        {
            get;
            private set;
        }
    }
}
