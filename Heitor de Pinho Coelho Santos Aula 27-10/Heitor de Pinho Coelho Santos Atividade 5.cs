using System;
					
public class Program
{
	public static bool ehPrimo(int n){ 
		int i, m=0;
          m=n/2;    
          for(i = 2; i <= m; i++)    
          {    
           if(n % i == 0){    
             return false;  
            }    
          }
           return true;
		}
	
	public static void ehDivisor(int numero_usuario){
		int Salvanumero = 0;
		Console.WriteLine("Divisores:"); 
		for(int i = 1; i <= numero_usuario; i++){
			
			if(numero_usuario%i==0){
				Salvanumero = i;
				if(Salvanumero%Salvanumero == 0 && Salvanumero%1 == 0){
					if(ehPrimo(Salvanumero) == true){
						Console.WriteLine(Salvanumero+" é primo");
					} else{
						Console.WriteLine(Salvanumero+" não é primo");
					}
				}
			}
		}
	}
	
	public static int leValor(int n){ 
		Console.WriteLine("Digite o número: ");    
		n = int.Parse(Console.ReadLine());
		return n;
	}
	public static void Main()
	{   
		int i=0;
	    ehDivisor(leValor(i));
	}
}