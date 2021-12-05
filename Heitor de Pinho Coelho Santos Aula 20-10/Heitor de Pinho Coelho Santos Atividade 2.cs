using System;

public class Program
{
    public static void Main()
     {
            int a, b, maior, menor;
            Console.WriteLine("digite o primeiro valor");
		    a = int.Parse(Console.ReadLine());
		    Console.WriteLine("digite o segundo valor");
		    b = int.Parse(Console.ReadLine());
		    
		    if(a>b){
		        maior=a;
		        menor=b;
		    } else{
		        maior=b;
		        menor=a;
		    }
            Recebe(maior,menor);
        }

        static void Recebe(int a, int b){
            int contador=0;
            int c=a;
            for(int i =0; i < c; i++){
                if((a%b)==0){
                    a = a/b;
                    contador++;
                }
            }
            Console.WriteLine("é divisível "+contador+" vezes");
        }
}