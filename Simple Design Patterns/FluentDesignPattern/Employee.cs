using System;

namespace FluentDesignPattern
{
    public class Employee
    {
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public int MobileNo { get; set; }

        public Employee SetFullName(string name)
        {
            this.FullName = name;
            return this;
        }

        public Employee Born(string dob)
        {
            this.DOB = DateTime.Parse(dob);
            return this;
        }

        public Employee LivesOn(string address)
        {
            this.Address = address;
            return this;
        }

        public Employee WorkingAs(string jobtitle)
        {
            this.Occupation = jobtitle;
            return this;
        }

        public Employee CallTo(int mobileNo)
        {
            this.MobileNo = mobileNo;
            return this;
        }




    }
}
