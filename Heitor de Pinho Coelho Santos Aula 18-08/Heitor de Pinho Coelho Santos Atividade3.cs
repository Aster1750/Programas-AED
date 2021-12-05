using System;
					
public class Program
{
	public static void Main()
	{
		double n1, n2, n3, media;
		Console.WriteLine("Digite a primeira nota: ");
		
		n1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Digite a segunda nota: ");
		
		n2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Digite a terceira nota: ");
		
		n3 = Convert.ToInt32(Console.ReadLine());
		
		media = ((n1*2)+(n2*3)+(n3*5))/10;
				
		Console.Write(media);
		
	}
}