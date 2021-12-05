using System;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
		char[,] matriz = new char [4, 4];
		int a, b;

		for(int i = 0; i<4; i++){
			for(int j=0; j<4; j++){
				a = rnd.Next(0, 4);
				b = rnd.Next(0, 4);
				if(i==a || j==a){
					if(a == b){
                        matriz[i,j] = 'B';
                    }else{
                        matriz[i,j] = 'S';
                    }
				} else{
					matriz[i,j] = 'X';
				}
				
			}
		}
		int cord1, cord2;
		char win='X';
		while(win=='X'){
			Console.WriteLine("digite a linha e a coluna da posição desejada respectivamente:");
			cord2 = int.Parse(Console.ReadLine());
			cord1 = int.Parse(Console.ReadLine());
			
			if(matriz[cord1, cord2]=='S'){
				Console.WriteLine("Parabéns, vc Venceu!!!");
				win='S';
			} else if(matriz[cord1, cord2]=='B'){
				Console.WriteLine("Perdeu, Otário!!!");
				win='B';
			} else {
				Console.WriteLine("Acertou a água!!");
			}
			
		
		}
		
		for(int i = 0; i<4; i++){
			for(int j=0; j<4; j++){
				Console.Write(matriz[i,j]);
			}
			Console.WriteLine();
		}
    }
}