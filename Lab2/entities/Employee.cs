using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.entities
{
    internal class Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for general employee.
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected long sin;
        protected string birthdate;
        protected string department;
        

        public string Id
        {
            get { return id; }
        }

        public string Name
        {
            get => name;
        }

        public virtual double Pay
        {
            get
            {
                return 0;
            }
        }
        //
        public string Address
        {
            get { return address; }
        }

        public string Phone
        {
            get { return phone; }
        }

        public long Sin
        {
            get { return sin; }
        }

        public string Birthdate
        {
            get { return birthdate; }
        }

        public string Department
        {
            get { return department; }
        }

        /// <summary>
        /// No-arg constructor
        /// </summary>
        public Employee(string id, string name, string address, string phone, long sin, string birthdate, string department)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.birthdate = birthdate;
            this.department = department;
        }

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /*public Employee(string id, string name)
        {
            this.id = id;
            this.name = name;
        }*/
    }
}