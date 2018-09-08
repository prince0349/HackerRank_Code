using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System;

class Program {


    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));       
        
		//For reversing elements
		var add = arr.Reverse();
        
        foreach(var a in add)
        {
            Console.Write(a + " ");
        }
        
    }
}