using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");

		Random rnd = new Random();
		int[,] matriz = new int[5,5];
		
		for(int i=0; i<5; i++){
			for(int j=0; j<5;j++){
				matriz[i, j] = rnd.Next(1, 50);
				Console.Write(matriz[i, j]+"-");	
			}
			Console.WriteLine("");
		}
		int num; 
		
		for(int l = 0; l < 5; l++) {
        	for(int c = 0; c < 5; c++) {
            num = matriz[l,c];
            for(int p = 2; p <= num; p++) {
               int resto = num % p;
				if (resto == 0)
				{
					p = num + 1;
				} else {
					Console.WriteLine("O número "+num+" é primo e se encontra na posição "+l+" "+c);
				}     
            }
        }
    }

	}
}