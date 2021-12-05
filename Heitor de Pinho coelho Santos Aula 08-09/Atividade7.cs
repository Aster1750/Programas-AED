using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		int fat = 1, num, N;
		Console.WriteLine("Digite o número de valores que deseja digitar");
		N = int.Parse(Console.ReadLine());
		
		for (int i=0; i<N; i++){
			Console.WriteLine("Digite um número inteiro");
			num = int.Parse(Console.ReadLine());
			while (num != 1){
				fat = fat * num;
				num = num - 1;
			}
			Console.WriteLine("O fatorial desse número é "+fat);
			fat=1;
		}		
	}	
}