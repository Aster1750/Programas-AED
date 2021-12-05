using System;
                    
public class Program
{
    public static void Main()
    {
        int cont = 0;
        int[,] matriz = new int[3, 5];
		
		for(int i=0; i<3; i++){
			for(int j=0; j<5; j++){
				Console.WriteLine("digite um número para a posição:"+i+" "+j);
				matriz[i, j] = int.Parse(Console.ReadLine());
				if(matriz[i, j] > 15 && matriz[i, j] < 20){
					cont++;
				}
			}
		}
		Console.WriteLine("A quantidade de elementos entre 15 e 20 é: "+cont);
    }
}