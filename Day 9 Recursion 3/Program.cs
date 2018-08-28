using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Program {

	// Complete the factorial function below.
    static int factorial(int n) {
		
        if(n <= 1)
            return 1;
        else
			return  n * factorial(n-1);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int result = factorial(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}