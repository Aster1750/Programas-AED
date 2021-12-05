using System;
					
public class Program
{
	public static void Main()
	{   
		Double N;

		Console.WriteLine("Digite o valor de N");
		N = Double.Parse(Console.ReadLine());
		Double S = 1;
		
		while(N>0){
		Double num=N, resultado=1;	
		
		while (num != 1){
                resultado = resultado * num;
                num = num - 1;
            }
			
		S = S + (1/resultado);
			
		N--;	
		}
		
		Console.WriteLine("O valor de S é: "+S );
	}
}