namespace Banking_Transaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            var customer = b1.Customer(123, "Satya", "Cranston RI", 500);
            b1.Deposit(500);
            b1.Withdraw(100);

            try
            {
                b1.Withdraw(5000);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            b1.GetCustomerInfo();
        }
    }
    public class Customer
    {
        private int customerId;
        private string customerName;
        private string customerAddress;
        private double accountBalance;
        public Customer() { }
        public Customer(int customerId, string customerName, string customerAddress, double accountBalance)
        {
            this.customerId = customerId;
            this.accountBalance = accountBalance;
            this.customerName = customerName;
            this.customerAddress = customerAddress;
        }
        public int CustomerId { get { return customerId; } }
        public string CustomerName { get { return customerName; } }
        public string Address { get { return customerAddress; } }
        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }
    }
    public class Bank
    {
        private Customer customer { get; set; }
        public Customer Customer(int customerId, string customerName, string customerAddress, double accountBalance)
        {
            this.customer = new Customer(customerId, customerName, customerAddress, accountBalance);
            return this.customer;
        }
        public void Deposit(double amount)
        {
            this.customer.AccountBalance += amount;
            Console.WriteLine($"Balance becomes{this.customer.AccountBalance}");
        }
        public void Withdraw(double amount)
        {
            if(amount> customer.AccountBalance)
            {
                throw new InvalidOperationException("Insufficient balance");
            }
            this.customer.AccountBalance -= amount;
            Console.WriteLine($"Balance becomes{this.customer.AccountBalance}");

        }
        public double GetBalance(Customer customer)
        {
            return customer.AccountBalance;
        }
        public bool IsEnoughBalance(double amcount)
        {
            return customer.AccountBalance.CompareTo(amcount)>0;
        }
        public void GetCustomerInfo()
        {
            Console.WriteLine($"{this.customer.CustomerId},{this.customer.CustomerName},{this.customer.Address},{this.customer.AccountBalance}");
        }
    }
}