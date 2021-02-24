using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Asignment2._2
{
    public class PM 
    {
        string PMName;
        int PMYear;

        public string Name
        {
            get 
            { 
                return PMName; 
            }
            set 
            { 
                PMName = value; 
            }
        }

        public int Year
        {
            get 
            { 
                return PMYear; 
            }
            set 
            { 
                PMYear = value; 
            }
        }
        public override string ToString()
        {
            return "Name:" + Name + ", " + "Year:" + Year;
        }
        public PM(string name,int year)
        {
            this.Name = name;
            this.Year = year;
        }
    }
}