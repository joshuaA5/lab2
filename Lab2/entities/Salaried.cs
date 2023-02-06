using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.entities
{
    internal class Salaried : Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for salaried employee.
        private double salary;
        private string id;
        private string name;
        private string address;
        private string phone;
        private long sin;

        public double Salary
        {
            get
            {
                return salary;
            }
        }

        public override double Pay
        {
            get
            {
                return salary;
            }
        }

        //

        public string Id
        {
            get { return id; }
        }
        public string Name
        {
            get => name;
        }

        public string Address
        {
            get 
            {
                return address;
            }
        }

        public string Phone
        {
            get { return phone; } 
        }

        public long Sin
        {
            get { return sin; }
        }

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        public Salaried(string id, string name, double salary, string address, string phone, long sin)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
        }
    }
}
