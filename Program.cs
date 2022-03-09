using System;

namespace Algorithm_Problems
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Enter max size: ");
			int n = int.Parse(Console.ReadLine());


			/* Creating Stack */
			StackLogic stackLogic = new StackLogic(n);
			Console.WriteLine();
			Console.WriteLine("Parenthesis Matching");
			Console.WriteLine();


			/* Accepting expression */
			Console.WriteLine("Enter expression: ");
			string exp = "(5+6)∗(7+8)/(4+3)(5+6)";

			Console.WriteLine("Matches and Mismatches: ");

			for (int i = 0; i < exp.Length - 1; i++)
			{
				char ch = exp[i];

				if (ch == '(')
				{
					stackLogic.push(i);
				}
				else if (ch == ')')
				{
					try
					{
						long p = (stackLogic.pop() + 1);
						Console.WriteLine("')' at index " + (i + 1) + " matched with '(' at index " + p);
					}
					catch (Exception e)
					{
						Console.WriteLine("')' at index " + (i + 1) + " is unmatched");
					}
				}
				while (!stackLogic.isEmpty())
				{
					Console.WriteLine("'(' at index " + (stackLogic.pop() + 1) + " is unmatched");
				}
			}
		}
	}
}