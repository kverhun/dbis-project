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

using System.ComponentModel;

namespace dbis_project.View_Model
{

    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DelegateCommand : ICommand
    {
        private readonly Action action;

        public DelegateCommand(Action action)
        {
            this.action = action;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
        public void Execute(object parameter)
        {
            this.action();
        }
    }

    public class ViewModel : ObservableObject
    {
        
        
        #region Properties

        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                RaisePropertyChangedEvent("Username");
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                RaisePropertyChangedEvent("Password");
            }
        }

        private string newProjectName;
        public string NewProjectName
        {
            get
            {
                return newProjectName;
            }
            set
            {
                newProjectName = value;
                RaisePropertyChangedEvent("NewProjectName");
            }
        }

        private string newProjectDescription;
        public string NewProjectDescription
        {
            get
            {
                return newProjectDescription;
            }
            set
            {
                newProjectDescription = value;
                RaisePropertyChangedEvent("NewProjectDescription");
            }
        }
        
        #endregion

        #region commands

        public ICommand LogIn
        {
            get { return new DelegateCommand(logIn); }
        }

        #endregion

        #region handlers

        private void logIn()
        {
            if (((App)App.Current).GetPassword() == "qwerty")
            {
                this.Username = "Success!!!111";
            }
            else
            {
                this.Username = "Looooseeeeeer!!!11!!";
            }
        }

        #endregion

        private string someValue;
        public string SomeValue
        {
            get
            {
                return someValue;
            }
            set
            {
                someValue = value;
                RaisePropertyChangedEvent("SomeValue");
            }
        }
    }
}
