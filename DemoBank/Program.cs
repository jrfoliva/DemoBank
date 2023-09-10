using DemoBank.Entities;

namespace DemoBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Experimentando UpCasting e DowCasting

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING ou seja, atribuir uma subclase para a superclasse
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.00, 1.0);
            //Estas instanciações são perfeitamente possíveis

            //DOWNCASTING ou seja, atribuiru uma superclasse para a subclasse

            //gerando Erro em tempo de execução
            //BusinessAccount acc5 = (BusinessAccount)acc3; //acc3 é do tipo SavingsAccount, por isso ocorre o erro.
            //É necessário testar antes do Dowcasting
            if (acc3 is  BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3; //atribuir uma subclasse a outra subclasse. Errro, pois não são compatíveis
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3; // Ok, pois são compatíveis
                SavingsAccount acc5 = acc3 as SavingsAccount; // Pode se usar também a palavra "as" para a conversão.
                acc5.UpdateBalance();
                Console.WriteLine("Updated!");
            }


        }
    }
}