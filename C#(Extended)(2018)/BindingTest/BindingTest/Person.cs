using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingTest
{
    public class Person : INotifyPropertyChanged
    {
        private string name = String.Empty;
        private string surname = String.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public Person(string _name = "Jezy", string _surname = "Kowalski")
        {
            name = _name;
            surname = _surname;
        }

        public override string ToString()
        {
            return name + " " + surname;
        }

        public string PersonName
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                NotifyPropertyChanged("PersonName");
            }
        }

        public string PersonSurname
        {
            get
            {
                return this.surname;
            }

            set
            {
                this.surname = value;
                NotifyPropertyChanged("PersonSurname");
            }
        }
    }
}
