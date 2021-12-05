using System;
					
public class Program
{
	public static void Main()
	{
		double anoA, anoN, idade, idade2050;
		Console.WriteLine("Digite o seu ano de nascimento");
		anoN = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o ano atual");
		anoA = int.Parse(Console.ReadLine());
		
		idade = anoA - anoN;
		
		idade2050 = 2050 - anoN;
		
		Console.WriteLine("Sua idade é: "+idade+" anos");
		
		Console.WriteLine("Sua idade em 2050 será "+idade2050+" anos");
	}
}