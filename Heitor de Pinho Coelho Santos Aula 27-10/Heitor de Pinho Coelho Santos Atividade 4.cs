using System;
					
public class Program
{
	public static void Main()
	{   
		 int n, i, m=0, f=0;    
          Console.WriteLine("Digite o número: ");    
          n = int.Parse(Console.ReadLine());  
          m=n/2;    
          for(i = 2; i <= m; i++)    
          {    
           if(n % i == 0)    
            {    
             Console.WriteLine("Não é primo.");    
             f=1;    
             break;    
            }    
          }    
          if (f==0)    
           Console.WriteLine("É Primo");    
	
	}
}
