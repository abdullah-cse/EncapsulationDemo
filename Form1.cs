using System;
using System.Windows.Forms;

namespace EncapsulationDemo
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        //Variable & Method Declaration Starts.
        private double balance = 0;
        public void Deposit(double n)
        {
            balance += n;
        }
        public void Withdraw(double n)
        {
            balance -= n;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void ShowBalance()
        {
            textBoxBalance.Text = GetBalance().ToString();
        }
        //Variable & Method Declaration Ends.


        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            Deposit(Convert.ToDouble(textBoxDeposit.Text));
            MessageBox.Show("Deposited Successfully");
            //ShowBalance();
        }

        private void buttonWithdrow_Click(object sender, EventArgs e)
        {
            Withdraw(Convert.ToDouble(textBoxWithdraw.Text));
            MessageBox.Show("Withdrawn Successfully");
            //ShowBalance();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            ShowBalance();
        }
        /*Why it's called encapsulation?
        * Becasuse you can't access the Balance directly.
        * You must goes throw Provide Method
        * Either Deposit
        * OR
        * Withdraw
        * You may see the Balance Also
        */
    }
}
