
    internal class Conta
    {
        public int NumeroC { get; set; }
        public string Agenncia { get; set; }
        public string Titular { get; set; }
        public double SaldoC { get; set; }

   
    public Conta(int numeroC, string agenncia, string titular, double saldoC, double valor)
        {
            NumeroC = numeroC;
            Agenncia = agenncia;
            Titular = titular;
            SaldoC = saldoC;
           
        }

        public void Sacar(double valor,double saldoC)
        {
            double conta = 0;
            if(valor < saldoC)
            {
                conta = SaldoC - valor;
            }
            Console.WriteLine($"seu saldo atual agora é {conta} reais");
        }

        public void Depositar(double valor,double saldoC)
        {
           double conta2  = SaldoC + valor;
               
            
            Console.WriteLine($"seu saldo atual agora é {conta2} reais");
        }
    }

