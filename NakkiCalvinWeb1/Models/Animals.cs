using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NakkiCalvinWeb1.Models
{
    public class Animals
    {
        private String name;
        private int age;

        public Animals(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public String getName
        {
            get { return this.name; }
        }

        public int getAge
        {
            get { return this.age; }
        }
    }
}