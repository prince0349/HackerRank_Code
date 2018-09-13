using System;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        try
        {
            int n = Int32.Parse(S);
            Console.WriteLine(S);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bad String");
        }
    }
}