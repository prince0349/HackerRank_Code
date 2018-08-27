using System;
using System.Collections.Generic;
using System.IO;

class Person {
    public int age;     
	public Person(int initialAge) {
        if(initialAge < 0)
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            initialAge = 0;
        }
        age = initialAge;
        // Add some more code to run some checks on initialAge
     }
     public void amIOld() {
         if(age < 13)
             Console.WriteLine("You are young.");
         else if(age >=13 && age < 18)
             Console.WriteLine("You are a teenager.");
         else
             Console.WriteLine("You are old.");
        // Do some computations in here and print out the correct statement to the console 
     }

     public void yearPasses() {
        // Increment the age of the person in here
         age = age + 1;
     }
}
class Program
{
    static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}