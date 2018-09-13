using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
	public Difference(int[] a)
	{
		elements = a;
	}
	public void computeDifference()
	{
		int max = 0;
		for (int i = 0; i < elements.length-1; i++) 
		{
		  for (int j = i+1; j < elements.length; j++) 
		  {
			  int diff = Math.abs(elements[i] - elements[j]);
			  if (diff > max) 
				  max = diff;
			}
		}
		maximumDifference = lst.Max();
	}
} // End of Difference Class

class Program {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}