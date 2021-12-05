using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		int m, n, soma=0;
		Console.WriteLine("Digite o M, depois o N");
		m = int.Parse(Console.ReadLine());
		n = int.Parse(Console.ReadLine());
		for(int i=n; i<m+1; i++){
			soma = soma + i;
		}
		Console.WriteLine("A soma é "+soma);
		soma=0;
		while(n < m){
			Console.WriteLine("Digite o M, depois o N");
			m = int.Parse(Console.ReadLine());
			n = int.Parse(Console.ReadLine());
			for(int i=n; i<m+1; i++){
				soma = soma + i;
			}
			Console.WriteLine("A soma é "+soma);
			soma=0;
		}
	}	
}