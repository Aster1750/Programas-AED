using System;
					
public class Program
{
	public static void Main()
	{
		double x1, y1, x2, y2;
		Console.WriteLine("Digite o valor de x1: ");
		
		x1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Digite o valor de y1: ");
		
		y1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Digite o valor de x2: ");
		
		x2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Digite o valor de y2: ");
		
		y2 = Convert.ToInt32(Console.ReadLine());
		
		double Result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
		
		Console.Write(Result);
		
	}
}