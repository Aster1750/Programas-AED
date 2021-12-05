using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");

		Random rnd = new Random();
		int[,] matriz = new int[4,4];
		int[] vetMaior = new int[4]; 
		int[] vetMenor = new int[4]; 
		int i=0, j=0, maior=0, menor=10;
		for(i=0; i<4; i++){
			for(j=0; j<4;j++){
				matriz[i, j] = rnd.Next(0, 10);
				Console.Write(matriz[i, j]+"-");
			}
			Console.WriteLine("");
		}
		for(i=0; i<4; i++){
			for(j=0; j<4;j++){
				if(matriz[i, j]>maior){
					maior = matriz[i,j];
				}
			}
			vetMaior[i]=maior;
			maior=0;
		}
		Console.WriteLine("");
		for(i=0; i<4; i++){
			Console.Write(vetMaior[i]);
		}
		
		for(j=0; j<4; j++){
			for(i=0; i<4;i++){
				if(matriz[i, j]<menor){
					menor = matriz[i,j];
				}
			}
			vetMenor[j]=menor;
			menor=10;
		}
		Console.WriteLine("");
		for(i=0; i<4; i++){
			Console.Write(vetMenor[i]);
		}
    }
}