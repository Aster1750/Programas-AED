using System;
                    
public class Program
{
    public static void Main()
    {
        
		Random rnd = new Random();
        int[,] matriz = new int[5, 5];
		int[] vet1 = new int[5], vet2 = new int[5];
		
		for(int i=0; i<5; i++){
			for(int j=0; j<5; j++){
				Console.WriteLine("digite um número para a posição:"+i+" "+j);
				matriz[i, j] = int.Parse(Console.ReadLine());
				vet1[i]+=matriz[i, j];
			}
		}
		
		for(int j=0; j<5; j++){
			for(int i=0; i<5; i++){
				vet2[j]+=matriz[i, j];
			}
		}
		
		for(int i=0; i<5; i++){
			for(int j=0; j<5; j++){
				Console.Write(matriz[i, j]+" ");
			}
			Console.WriteLine();
		}
		
		Console.WriteLine("Vetor com Soma das Linha:");
		for(int i=0; i<5; i++){
			Console.Write(vet1[i]+"  ");
		}
		Console.WriteLine();
        Console.WriteLine("Vetor com Soma das Coluna:");
		for(int i=0; i<5; i++){
			Console.Write(vet2[i]+"  ");
		}
    }
}