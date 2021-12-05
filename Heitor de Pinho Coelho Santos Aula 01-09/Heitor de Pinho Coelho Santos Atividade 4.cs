using System;
					
public class Program
{
	public static void Main()
	{
		int opcao, salario;
		
		Console.WriteLine("Menu de opções:");
		Console.WriteLine("1. Imposto");
		Console.WriteLine("2. Novo salário");
		Console.WriteLine("3. Classificação");
		Console.WriteLine("digite a opção desejada");
		opcao = int.Parse(Console.ReadLine());
		Console.WriteLine("digite seu salário");
		salario = int.Parse(Console.ReadLine());

		switch (opcao)
        {
            case 1:
                if (salario < 500){
                    Console.WriteLine("o valor do imposto é: "+salario*0.05);
                } else if (salario >= 500 && salario <= 850){
                    Console.WriteLine("o valor do imposto é: "+salario*0.10);
                } else if (salario < 500){
                    Console.WriteLine("o valor do imposto é: "+salario*0.15);
                }
                break;
            case 2:
                if (salario > 1500){
                    Console.WriteLine("o novo salário é: "+(salario+25));
                } else if (salario >= 750 && salario <= 1500){
                    Console.WriteLine("o novo salário é: "+(salario+50));
                } else if (salario >= 450 && salario < 750){
                    Console.WriteLine("o novo salário é: "+(salario+75));
                } else if (salario < 450){
                    Console.WriteLine("o novo salário é: "+(salario+100));
                }
                break;
            case 3:
                if (salario <= 700){
                    Console.WriteLine("Mal remunerado");
                } else{
                    Console.WriteLine("Bem remunerado");
                }
                break;
            default:
                Console.WriteLine("opção inexistente");
                break;
        }
	}
}