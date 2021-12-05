using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");

		Random rnd = new Random();
		int[,] matriz = new int[4,4];
		int i=0, j=0, colunas=0, linhas=0, zeros=0;
		for(i=0; i<4; i++){
			for(j=0; j<4;j++){
				matriz[i, j] = rnd.Next(0, 10);
				Console.Write(matriz[i, j]+"-");
			}
			Console.WriteLine("");
		}
		
		for(i=0; i<4; i++){
			zeros=0;
			for(j=0; j<4;j++){
				if(matriz[i, j]==0){
					zeros++;
				}	
			}
			if(zeros == 4){
				linhas++;
			}
			Console.WriteLine("");
		}
		
		for(j=0; j<4; j++){
			zeros=0;
			for(i=0; i<4;i++){
				if(matriz[i, j]==0){
					zeros++;
				}	
			}
			if(zeros == 4){
				colunas++;
			}
			Console.WriteLine("");
		}
		Console.WriteLine("Linhas nulas: "+linhas);
		Console.WriteLine("Colunas nulas: "+colunas);
    }
}