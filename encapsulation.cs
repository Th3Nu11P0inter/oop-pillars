public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        // Perform validation and update the balance
		
        balance = balance + amount;
    }

    public void Withdraw(decimal amount)
    {
        // Perform validation and update the balance
		if (balance > amount) {
            balance = balance - amount;
        }
    }
}