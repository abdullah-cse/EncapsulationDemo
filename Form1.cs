using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //Variable & Method Declaration Ends.




    }
}
