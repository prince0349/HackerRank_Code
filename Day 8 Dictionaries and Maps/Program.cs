using System;
using System.Collections.Generic;
using System.IO;

class Program {
	
    static void Main(String[] args) {
		
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
		
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
		
		//Add data to dictionary
        for(int i=0;i<n;i++)
        {
            string [] list = Console.ReadLine().ToString().Split(' ');
            phoneBook.Add(list[0], list[1]);
        }
		
        for(int i=0;i<n;i++)
        {
			string s = Console.ReadLine();
        
			if(phoneBook.ContainsKey(s))
				Console.WriteLine(string.Format("{0}={1}",s,phoneBook[s]));
            else
                Console.WriteLine("Not found");
        }

    }
}