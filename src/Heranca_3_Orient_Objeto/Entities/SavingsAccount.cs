
namespace Heranca_3_Orient_Objeto.Entities
{
    class SavingsAccount: Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance,double interestRate):base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            //Balance -= amount; (Dessa forma não traz as alterações da superclasse)
            //Na solução abaixo, traz o metodo da superclasse e é possivel acrescentar mais coisas.
            base.Withdraw(amount);
            Balance -= 2.0;

        }

    }
}
