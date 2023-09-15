
    internal class Cempresa:Conta

    {
        public double Anuidade { get; set; }
        public double Lemprestimo { get; set; }
        public double Temprestimo { get; set; }

      
        public Cempresa(double anuidade, double lemprestimo, double temprestimo,double valorEmprestimo,
            int numeroC, string agenncia, string titular, double saldoC, double valor):base( numeroC,  agenncia,  titular,  saldoC,  valor)
        {
            this.Anuidade = anuidade;
            Lemprestimo = lemprestimo;
            Temprestimo = temprestimo;
        }
        public void FzrEmprestimo(double valorEmprestimo)
        {
           
            if(valorEmprestimo < Lemprestimo)
            {
              SaldoC += valorEmprestimo;
              Temprestimo += valorEmprestimo;
              Console.WriteLine($"empréstimo foi realizado com sucesso");
            }
            
            else if(valorEmprestimo > Lemprestimo)
            {
                Console.WriteLine("o valor de empréstimo não pode ser concedido");
            }
            
        }
        public void Sacar(double saldoC,double valor)
        {
            double conta2 = 0;
            double conta3 = 0;
            if(valor < 5000)
            {
                conta2 = valor - saldoC;
                conta3 = conta2 - 5;
                Console.WriteLine(conta3);
            }

        }
    }

