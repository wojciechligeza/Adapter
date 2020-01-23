using System;
using System.Collections.Generic;

namespace Adapter
{
    class ThirdPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> EmployeeList = new List<string>();

            EmployeeList.Add("Piotr");
            EmployeeList.Add("Zbyszek");
            EmployeeList.Add("Heniu");
            EmployeeList.Add("Roman");

            return EmployeeList;
        }
    }

    interface ITarget
    {
        List<string> GetEmployees();
    }

    class EmployeeAdapter : ThirdPartyEmployee, ITarget
    {
        public List<string> GetEmployees()
        {
            return GetEmployeeList();
        }
    }

    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista pracowników od zewnetrznej organizacji");
            Console.WriteLine("---------------------------------------------");

            ITarget adapter = new EmployeeAdapter();

            foreach (string employee in adapter.GetEmployees())
            {
                Console.WriteLine(employee);
            }
            Console.ReadKey();
        }
    }
}
