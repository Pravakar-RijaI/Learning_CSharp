using System;
using System.Net.Cache;

namespace ClassType
{
    internal class PrivateClass
    {
        //private DateTime _birthdate;

        /*public void SetBirthdate (DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate ()
        {
            return _birthdate;
        }*/
        public DateTime Birthdate { get; private set; }
        public int Age
        {
            get
            { 
                return (DateTime.Today - Birthdate).Days / 365;
            }
        }

        public PrivateClass(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }
    }
}
