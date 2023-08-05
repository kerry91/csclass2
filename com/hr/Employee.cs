using System;

namespace com.hr
{
    class Employee : IComparable<Employee>
    {
        public string Firstname
        { get; set; }

        public string Lastname
        { get; set; }

        public decimal Salary
        { get; set; }

        public int CompareTo(Employee obj)
        {
            if (obj == null) return 1;
            return this.Salary.CompareTo(obj.Salary);
        }

        public static Employee CsvToEmp(string csv)
        {
            string[] toks = csv.Split(',');
            Employee emp = new Employee();
            emp.Firstname = toks[0];
            emp.Lastname = toks[1];
            emp.Salary = Convert.ToDecimal(toks[2]);
            return emp;
        }

        public override string ToString() => "Employee [firstname=" + Firstname + ", lastname=" + Lastname + 
        ", salary=" + Salary + "]";
        
    }
}