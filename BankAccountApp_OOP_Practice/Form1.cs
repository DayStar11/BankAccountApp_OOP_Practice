namespace BankAccountApp_OOP_Practice
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>(); //grid list
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*BankAccount bankAccount = new BankAccount("Daiyaan Motala");
            bankAccount.Owner = "Daiyaan Motala";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 7777777;

            BankAccount bankAccount2 = new BankAccount("Morningstar");
            bankAccount2.Owner = "Morningstar";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 7777777;

            BankAccount bankAccount3 = new BankAccount("FNBy Next");
            bankAccount3.Owner = "FNBy Next";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 150;

            BankAccount bankAccount4 = new BankAccount("FNB Easy");
            bankAccount4.Owner = "FNB Easy";
            bankAccount4.AccountNumber = Guid.NewGuid();
            bankAccount4.Balance = 50;*/

            /*List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);
            bankAccounts.Add(bankAccount4);

            gridBank.DataSource = bankAccounts;*/
            //commented out all hard coding but left it in for potential future reference
        }

        private void gridBank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ttbOwner.Text))
            {
                MessageBox.Show("Input Account Owners Name");
                return;
            }
            //will not create empty bank accounts

            if (nudInterest.Value > 0) 
            {
                SavingsAccount savingsAccount = new SavingsAccount(ttbOwner.Text, nudInterest.Value);
                BankAccounts.Add(savingsAccount);
            }
            //creates a savings account
            else
            {
            BankAccount bankAccount = new BankAccount(ttbOwner.Text);
            BankAccounts.Add(bankAccount);
            //add bank accounts to the BankAccounts list
            }

            RefreshGrid();
            ttbOwner.Text = string.Empty;
            //makes it so that all text in the textbox is removed after an account is created
            nudInterest.Value = 0;
            //clears interest rate number
        }

        private void RefreshGrid()
        //refresh grid method
        {
            gridBank.DataSource = null;
            //clears the grid before adding data to it
            gridBank.DataSource = BankAccounts;
            //the grids data source = BankAccounts list
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (gridBank.SelectedRows.Count == 1 && nudAmount.Value > 0)
            {
                BankAccount selectedBankAccount = gridBank.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(nudAmount.Value);
                    //declared as string message because the Deposit method retuns messages after events.
                RefreshGrid();
                nudAmount.Value = 0;
                MessageBox.Show(message);
            }
            //allows us to deposit/add money into bank accounts
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (gridBank.SelectedRows.Count == 1 && nudAmount.Value > 0)
            {
                BankAccount selectedBankAccount = gridBank.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Withdraw(nudAmount.Value);
                    //declared as string message because the Withdraw method retuns messages after events.
                RefreshGrid();
                nudAmount.Value = 0;
                MessageBox.Show(message);
            }
            //allows us to withdraw/subtract money from bank accounts
        }
    }
}
