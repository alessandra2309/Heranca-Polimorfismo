
    internal class Cempresa:Conta

    {
        public double Anuidade { get; set; }
        public double Lemprestimo { get; set; }
        public double Temprestimo { get; set; }

      
        public Cempresa(double anuidade, double lemprestimo,
            int numeroC, string agenncia, string titular, double saldoC):base( numeroC,  agenncia,  titular, saldoC)
        {
            this.Anuidade = anuidade;
            Lemprestimo = lemprestimo;
          //  Temprestimo = temprestimo;
        }
        public void FzrEmprestimo(double valor)
        {
           
            if(valor <= Lemprestimo - Temprestimo)
            {
              SaldoC += valor;
              Temprestimo += valor;
            }
            else 
            {
                Console.WriteLine("o valor de empréstimo não pode ser concedido");
            }
            
        }
        public override void Sacar(double valor)
        {
            
            if (valor <= saldoC)
            {
                saldoC -= valor;
               if (valor >= 5000)
               {
                saldoC -= 5;
              
               }
            }
            else
            {
               Console.WriteLine("saldo insuficiente!");
            }
           

        }
    }

