using System.Collections.Generic;
using System.IO;
using System;

class Program {



    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        List<int> sumA= new List<int>();
  
         for (int i = 0; i < 4; i++) 
         {
             for (int j = 0; j < 4; j++) 
             {
                 int s = arr[i][j] + arr[i][j+1] + arr[i][j+2] + 
                                    arr[i+1][j+1] + 
                     arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                 
                 sumA.Add(s);
                 
             }
         }
        Console.WriteLine(sumA.Max());
    }
}
