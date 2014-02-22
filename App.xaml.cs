using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;


using dbis_project.View_Model;
using dbis_project.View;


namespace dbis_project
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ObservableObject ViewModel
        {
            get;
            set;
        }

        public string GetPassword()
        {
            return ((IHasPassword)MainWindow).GetPassword();
        }

    }
}
