using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Controller;
using HospitalManagementSystem.Model;

namespace HospitalManagementSystem.View
{
    public partial class TransactionHistoryForm : Form
    {
       
        public TransactionHistoryForm()
        {
            
            InitializeComponent();
            LoadTransactions();
        }
        private void LoadTransactions()
        {

            AuthController controller = new AuthController(new Data.Database());

            List<TransactionHistory> transactions = controller.GetAllTransactions();

            foreach (TransactionHistory transaction in transactions)
            {
                TransactionHistoryItem item = new TransactionHistoryItem();
                item.setTransactionData(transaction);
                transacFlowPanel.Controls.Add(item);

            }

        }
    }
}
