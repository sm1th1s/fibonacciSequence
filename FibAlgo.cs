//fib sequence
// 0+1=1 1+1=2 1+2=3 2+3=5 3+5=8 8+5=13 
// 1, 2, 3, 5, 8, 13

using System;
					
public class Program
{
	public static void Main()
	{
		printFib();
	}
		
		public static void printFib(){
			int startingPos = 12;//user input
			int noResults = 8; //number of results
			
				for(int n=startingPos; n<startingPos+noResults; n++){
				Console.WriteLine(Fib(n));}
			}
					
		public static int Fib(int n)
		{
			if(n<=1)
				return n;
			else
				return Fib(n-1)+ Fib(n-2);
		}
	
	
}
