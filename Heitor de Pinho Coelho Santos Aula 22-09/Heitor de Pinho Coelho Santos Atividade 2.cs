using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		
		int N, cont = 1;
		Console.WriteLine("digite o valor de N");
		N = int.Parse(Console.ReadLine());
		
		for(int i=0; i<N; i++){
			for(int j=0; j<N;j++){
				Console.Write(j+cont);	
			}
			Console.WriteLine("");
			cont++;
		}
	}
}