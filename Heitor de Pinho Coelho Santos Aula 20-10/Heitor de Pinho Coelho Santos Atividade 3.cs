using System;

public class Program
{
	 static void Recebe(int numero){
            int inversoN, aux;


            inversoN = 0; 
            aux = numero;


            while (aux > 0)
            {
                inversoN = (inversoN * 10) + (aux % 10);
                aux = aux / 10;
            }

            Console.WriteLine("\nNúmero: {0}\nNumero invertido: {1}\n", numero, inversoN);
            if (numero == inversoN)
            {
                Console.WriteLine("São capicua.\n\n");
            }
            else
            {
                Console.WriteLine("Não são capicua.\n\n");
            }

        }
    public static void Main()
     {
		{
			int numero;
			Console.Write("Digite o Número: ");
			numero = int.Parse(Console.ReadLine());
			Recebe(numero);
		}
	}
}