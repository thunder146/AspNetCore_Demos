using System;
using System.Collections.Generic;
using System.Text;

namespace MyFamilyApp.Data
{
    public class Family
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Family(string name)
        {
            Name = name;
        }
    }
}
