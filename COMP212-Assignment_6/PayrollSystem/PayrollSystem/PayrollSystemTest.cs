// Fig. 12.9: PayrollSystemTest.cs
// Employee hierarchy test app.
using System;
using System.Collections.Generic;
using System.Linq;

class PayrollSystemTest
{
   static void Main()
   {
      // create derived-class objects
      var salariedEmployee = new SalariedEmployee("John", "Smith",
          "111-11-1111", 800.00M);
      var hourlyEmployee = new HourlyEmployee("Karen", "Price",
         "222-22-2222", 16.75M, 40.0M);
      var commissionEmployee = new CommissionEmployee("Sue", "Jones",
         "333-33-3333", 10000.00M, .06M);
      var basePlusCommissionEmployee =
         new BasePlusCommissionEmployee("Bob", "Lewis",
         "444-44-4444", 5000.00M, .04M, 300.00M);

      Console.WriteLine("Employees processed individually:\n");

      Console.WriteLine($"{salariedEmployee}\nearned: " +
          $"{salariedEmployee.Earnings():C}\n");
      Console.WriteLine(
         $"{hourlyEmployee}\nearned: {hourlyEmployee.Earnings():C}\n");
      Console.WriteLine($"{commissionEmployee}\nearned: " +
          $"{commissionEmployee.Earnings():C}\n");
      Console.WriteLine($"{basePlusCommissionEmployee}\nearned: " +
          $"{basePlusCommissionEmployee.Earnings():C}\n");
      
      // create List<Employee> and initialize with employee objects
      var employees = new List<Employee>() {salariedEmployee,
         hourlyEmployee, commissionEmployee, basePlusCommissionEmployee};


        /*
         * Update the PayrollSytem by useing LINQ to map the List<Employee> in to a list of anonymous objects 
         * in which each object contains an Employee’s name and earning. When a BasePlusCommissionEmployee is 
         * encountered, give a 10% base-salary increase without modifying the original BasePlusCommissionEmployee 
         * object. Display the names and earnings. 
         * */
        Console.WriteLine("Question 2:\n");
        var employeesIncrease = from emp in employees
                                select new
                                    { emp.FirstName, emp.LastName, Earnings = 
                                      (emp.GetType() + "" != "BasePlusCommissionEmployee" ? 
                                      emp.Earnings() : Decimal.Multiply(emp.Earnings(), 1.1M)) };

        foreach (var item in employeesIncrease) Console.WriteLine(item);

        Console.WriteLine();
        Console.WriteLine("Employees processed polymorphically:\n");
             
        // generically process each element in employees
        foreach (var currentEmployee in employees)
      {
         Console.WriteLine(currentEmployee); // invokes ToString

         // determine whether element is a BasePlusCommissionEmployee
         if (currentEmployee is BasePlusCommissionEmployee)
         {
            // downcast Employee reference to 
            // BasePlusCommissionEmployee reference
            var employee = (BasePlusCommissionEmployee)currentEmployee;

            employee.BaseSalary *= 1.10M;
            Console.WriteLine("new base salary with 10% increase is: " +
                $"{employee.BaseSalary:C}");
         }

         Console.WriteLine($"earned: {currentEmployee.Earnings():C}\n");
      }

      // get type name of each object in employees 
      for (int j = 0; j < employees.Count; j++)
      {
         Console.WriteLine(
            $"Employee {j} is a {employees[j].GetType()}");
      }
   }
}


/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/
