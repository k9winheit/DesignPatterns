using System;

namespace FluentDesignPattern
{
    class Program
    {
        static void Main(string[] args = null)
        {
            Console.WriteLine("####### Fluent Design Pattern Example #####");
            Console.WriteLine("####### Using method chaining concept #####");            
            var employeeObj = new Employee().SetFullName("Kanishka Hewapathirana").
                                             Born("06/09/1988").
                                             LivesOn("Colombo 7").
                                             WorkingAs("Software Engineer").
                                             CallTo(0718546205);
           

            Console.WriteLine("Employee name " + employeeObj.FullName);
            Console.WriteLine("Employee Date of birth " + employeeObj.DOB.ToString());
            Console.WriteLine("Employee address " + employeeObj.Address);
            Console.WriteLine("Employee profession " + employeeObj.Occupation);
            Console.WriteLine("Employee contact no "+  employeeObj.MobileNo);

            Console.ReadLine();            
        }
    }
}
