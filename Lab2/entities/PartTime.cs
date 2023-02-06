using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.entities
{
    internal class PartTime : Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for part-time employee.
        private double rate;
        private double hours;
        private string id;
        private string name;
        private string address;
        private string phone;
        private long sin;


        public double Rate
        {
            get { return rate; }
        }

        public double Hours
        {
            get { return hours; }
        }

        public override double Pay
        {
            get
            {
                double rate = this.Rate;
                double hours = this.Hours;

                double pay = rate * hours;

                return pay;
            }
        }
        //
        public string Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

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

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="rate"></param>
        public PartTime(string id, string name, double rate, double hours, string address, string phone, long sin)
        {
            this.id = id;
            this.name = name;
            this.rate = rate;
            this.hours = hours;
            this.address = address;
            this.phone= phone;
            this.sin= sin;
        }
    }
}