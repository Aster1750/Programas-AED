using System;
                    
public class Program
{
    public static void Main()
    {
        
		char[,] matriz = new char [5, 5];

		for(int i = 0; i<5; i++){
			for(int j=0; j<5; j++){
				matriz[i,j] = ' ';
				if(i == j){
					matriz[i,j] = 'X';
				}
				if((i+j)==4){
					matriz[i,j] = 'X'; 
				}
			}
		}
		for(int i = 0; i<5; i++){
			for(int j=0; j<5; j++){
				Console.Write(matriz[i,j]);
			}
			Console.WriteLine();
		}
		
    }
}