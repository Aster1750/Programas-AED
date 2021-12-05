using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");

		int[] X = new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, Y = new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, Z = new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
		
		int z=0;
		
		for(int i=0; i<10; i++){
			Console.WriteLine("Digite um número para o vetor X");
			X[i] = int.Parse(Console.ReadLine());
		}
		for(int i=0; i<10; i++){
			Console.WriteLine("Digite um número para o vetor Y");
			Y[i] = int.Parse(Console.ReadLine());
		}
		for(int i=0; i<10; i++){
			for(int j=0; j<10; j++){
				if(X[i] == Y[j]){
					Z[z] = X[i];
					z++;
				}
			}
		}
		Console.WriteLine("Vetor Z:");
		for(int i=0; i<10; i++){
			Console.Write(Z[i]+"-");
		}
	}
}