using System.Globalization;

public class progam
{
    static void Main(string[] args)
    {
        int NumeroC = 1;
        string agenncia = "jipa";
        while (true)
        {
            Console.WriteLine("digite \n" + "1 para conta normal,\n"+"2 para conta estudante\n"+"3 para conta empresarial");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o nome do titular");
            string titular = Console.ReadLine();
            if (opcao == 1 )
            {
                Conta c = new Conta(10,"caixa","alessandra");
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if(opcao == 1)
                    {
                        Console.WriteLine("digite um valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Depositar(valor);
                    }
                    else if(opcao == 2)
                    {
                        Console.WriteLine("digite um valor");
                        double valor = Convert.ToDouble((Console.ReadLine()));
                        c.Sacar(valor);
                    }
                    else if (opcao == 3)
                    {
                        break;
                    }
                }
             
            }
            if (opcao == 2)
            {
                Console.WriteLine("digite o CPF do estudante");
                string cpf = Console.ReadLine();

                Console.WriteLine("informe a instituição");
                string instituicao = Console.ReadLine();
                Cestudante ce = new Cestudante(100,instituicao,cpf,NumeroC,agenncia, titular, 0);

                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("digite um valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Depositar(valor);
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("digite um valor");
                        double valor = Convert.ToDouble((Console.ReadLine()));
                        ce.Sacar(valor);
                    }
                    else if (opcao == 3)
                    {
                        break;
                    }
                }

            }
            if (opcao == 3)
            {
                Cempresa ces = new Cempresa(10, 1000,02,"caixa","alessanda",5000);
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("digite um valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ces.FzrEmprestimo(valor);
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("digite um valor");
                        double valor = Convert.ToDouble((Console.ReadLine()));
                        ces.Sacar(valor);
                    }
                    else if (opcao == 3)
                    {
                        break;
                    }
                }

            }

           

        }
    }
}




