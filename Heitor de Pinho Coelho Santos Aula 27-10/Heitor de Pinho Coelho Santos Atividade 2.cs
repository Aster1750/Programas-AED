using System;
					
public class Program
{
	public static void Main()
	{   
		int[] vet = new int[5];
		int maior=0, menor=0;

		Console.WriteLine("Digite os 5 valores na sequência");
		
		for(int i=0; i<5; i++){
			vet[i] = int.Parse(Console.ReadLine());
			if(i==0){
			 	menor=vet[i];
				maior=vet[i];
			}
			
			if (vet[i]>maior){
				maior=vet[i];
			}
			
			if (vet[i]<menor){
				menor=vet[i];
			}
		}

		Console.WriteLine("Maior número: "+maior);
		Console.WriteLine("Menor número: "+menor);
	}
}