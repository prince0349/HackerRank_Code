using System;
using System.Collections.Generic;
using System.IO;
class Program {
	
    static void Main(String[] args) {
		
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        string [] str = new string[n]; 
        for(int i=0;i< n;i++)
            str[i] = Console.ReadLine();
        
        string even = string.Empty;
        string odd = string.Empty;
        
        for(int i=0;i< n;i++)
        {
            for(int j=0; j<str[i].Length; j++)
            {
                if(j%2 == 0)
                    even = even + str[i][j];
                else
                    odd = odd + str[i][j];
            }
            
            Console.WriteLine(string.Format("{0} {1}", even, odd));
        }
        
    }
}