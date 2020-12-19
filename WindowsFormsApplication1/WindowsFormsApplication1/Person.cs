using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Person
    {
        public int Age
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }
        public override string ToString()
        {
            return string.Format("Name:{0},Age:{1}", this.Name, this.Age);
        }
    }
}
