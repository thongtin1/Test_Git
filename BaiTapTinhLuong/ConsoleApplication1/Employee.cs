using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employee
    {
        public string name;
        public string dob;
        public string role;
        public string startDate;
        public string startSal;
        public Employee(string name, string dob, string role, string startDate, string startSal)
        {
            this.name = name;
            this.dob = dob;
            this.role = role;
            this.startDate = startDate;
            this.startSal = startSal;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setDob(string dob)
        {
            this.dob = dob;
        }
        public string getDob()
        {
            return dob;
        }
        public void setRole(string role)
        {
            this.role = role;
        }
        public string getRole()
        {
            return role;
        }
        public void setStartDate(string startDate)
        {
            this.startDate = startDate;
        }
        public string getStartDate()
        {
            return startDate;
        }
        public void setStartSal(string startSal)
        {
            this.startSal = startSal;
        }
        public string getStartSal()
        {
            return startSal;
        }
    }
}
