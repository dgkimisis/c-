using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testapp 
{

  public class Person 
  {
    public string Name { get; set; }
    public int Age { get; set; }
  }


  public class Program
  {
   
    public delegate bool CheckAge(Person p);  
 
    
    static void Main(string [] args)
    {
      Person p1 = new Person() {Name = "Sabina", Age = 16};
      Person p2 = new Person() {Name = "John", Age = 51};
      Person p3 = new Person() {Name = "Jessica", Age = 25};
      Person p4 = new Person() {Name = "Dexter", Age = 14};
    
      List<Person> people = new List<Person>() {p1, p2, p3, p4};
    
      Report("Children:", people, Child);
      Report("Adult:", people, Adult);
    
      //Sabina is child
      //Johhn is adult
      //Jessica is adult
      //Dexter is child
      Console.Read();
    }
             
    static void Report(string title, List<Person> people, CheckAge check) 
    {
      Console.WriteLine(title);
             
      foreach (Person p in people) 
      {
        if (check(p)) 
        {
        Console.WriteLine("{0} is {1} years old", p.Name, p.Age);
        }
      }
    }   
      
      static bool Child(Person p)
      {
        return p.Age < 18;
      }
    
   	  static bool Adult(Person p)
      {
        return p.Age >= 18;
      }
   }  
}
