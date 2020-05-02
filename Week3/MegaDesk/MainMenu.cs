using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuoteForm = new ViewAllQuotes();
            viewAllQuoteForm.Tag = this;
            viewAllQuoteForm.Show(this);
            Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchQuotesAssignment SearchQuotesAssignment = new SearchQuotesAssignment();
            SearchQuotesAssignment.Tag = this;
            SearchQuotesAssignment.Show(this);
            Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
           
        }

     
    }
}
