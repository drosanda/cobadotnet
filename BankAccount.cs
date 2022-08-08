namespace MySuperBank
{
  public class BankAccount
  {
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    public BankAccount(string name, decimal initialBalance)
    {
      this.Owner = name;
      this.Balance = initialBalance;
    }
  }
}