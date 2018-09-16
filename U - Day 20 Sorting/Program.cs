using System;
using System.IO;
using System.Linq;
class Program 
{
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        // Write Your Code Here
        int numberSwap = 0;
        for(int i=0;i<n;i++)
        {
            for(int j=i;j<n;j++)
            {
                if(a[i] > a[j])
                {
                    int temp = a[i];
                    a[i]= a[j];
                    a[j]= temp;
                    numberSwap++;
                }
            }
        }
       
        Console.WriteLine("Array is sorted in "+ numberSwap +" swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[n-1]);
    }
}