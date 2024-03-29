using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Encapsulation
{
    internal class Person
    {

        private string _name;
        private string _surName;
        private int _age;
        private readonly bool _isMarried;

        public string Name {

            get {
                return this._name;
            }
            set 
            {
                if (value.Length > 4)
                {
                    this._name = value;
                }
                else
                {
                    Console.WriteLine("Adin uzunlugu duzgun qeyd edilmeyib");
                }
            }
        }
        public string SurName { get; }
        public int Age { get; set; }
        public bool IsMarried { get; }

        //public Person()
        //{
        //    this._isMarried = false;
        //}


        //public string getname()
        //{
        //    return this.name;
        //}

        //public void setName(string name)
        //{
        //    if (name.Length > 4)
        //    {
        //        this.Name = name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Adin uzunlugu duzgun qeyd edilmeyib");
        //    }
        //}

        //public int getAge()
        //{
        //    return this.Age;
        //}

        //public void setAge(int age)
        //{
        //    if (age >= 18)
        //    {
        //        this.Age = age;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Yashiniz duzgun deyil");
        //    }
        //}
    }
}
