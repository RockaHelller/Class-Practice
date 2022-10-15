using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRecordingPractice
{
    class Person : Group
    {
        internal string name;
        private protected string surname;
        protected string Address { get; set; }
        protected internal string Color { get; set; }
        private int _age;

        public int Age
        {
            get
            {
                if (_age < 18)
                {
                    Console.WriteLine("Can't see");
                    return -1;
                }
                return _age;
            }

            set
            {
                _age = value;
            }
        }

    }
}
