using System;

class Principal
{
    static void Main(string[] args)
    {

        //colocar quantidade de passagens para comprar
        //encerrar aplicação por uma opção ou por completar as passagens

        int contador = 0;
        string opcao = "";
        double valor;
        const string mensagem = "Passagem comprada! Digite qualquer tecla para continuar";

        Console.WriteLine("Quantas passagens deseja comprar?");
        int quantidadePassagens = int.Parse(Console.ReadLine());

        double[] valores = new double[quantidadePassagens];

        while (contador < valores.Length && opcao != "s")
        {
            Console.Clear();

            Console.WriteLine("Rio de Janeiro/RJ -> Ubatuba/SP\n");
            Console.WriteLine("Escolha sua passagem:");
            Console.WriteLine("[a] Viação Costa Verde");
            Console.WriteLine("[b] Viação 1001");
            Console.WriteLine("[c] Águia Branca");
            Console.WriteLine("[d] Util");
            Console.WriteLine("[s] Sair");



            Console.Write("\nOpção: ");
            opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "a":
                    valor = 550;
                    Console.WriteLine(mensagem);
                    Console.ReadLine();
                    break;
                case "b":
                    valor = 330;
                    Console.WriteLine(mensagem);
                    Console.ReadLine();
                    break;
                case "c":
                    valor = 630;
                    Console.WriteLine(mensagem);
                    Console.ReadLine();
                    break;
                case "d":
                    valor = 260;
                    Console.WriteLine(mensagem);
                    Console.ReadLine();
                    break;
                case "s":
                    Console.WriteLine("Saíndo do sistema");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Console.ReadLine();
                    contador--;
                    break;
                    
            }
            contador++;
        } 

        
            
        

            
        


        /*
            if (valor == 0)
        {
            Console.WriteLine("Passagem não comprada");
        } else
        {
            valores[contador] = valor;
            horas[contador] = hora;
            Console.WriteLine("Passagem comprada no valor de {0:c} para às {1} hrs.", valor, hora);
            contador++;
          
        }

        Console.WriteLine("\nDeseja comprar outra passagem?[s/n]");
        opcao = Console.ReadLine().ToLower();

        if (opcao == "s")
        {
            
        } else
        {
            Console.WriteLine("Deseja ver suas passagem compradas?[s/n]");
            opcao = Console.ReadLine().ToLower();
            if (opcao == "s")
            {
                for(int i = 0; i < valores.Length; i++) 
                {
                    Console.WriteLine("Passagem: valor {0:c} horas: {1} hrs", valores[i], horas[i]);
                }
            } else 
            {
                Console.WriteLine("Boa viagem!");
            }
        }*/


    }
}
