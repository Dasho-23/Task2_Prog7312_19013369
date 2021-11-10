using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _190133369Task1
{
    public partial class Dewey : Form
    {
        public Dewey()
        {
            InitializeComponent();
        }

        private void btnReplBook_Click(object sender, EventArgs e)
        {
            //object for the replacing books class
            ReplacingBooks rb = new ReplacingBooks();

            //shows the replacing books form
            rb.ShowDialog();

            //close the current/dewey form
            this.Close();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            //stops the execution of the program
            this.Close();
            
        }

        private void btnIdentAreas_Click(object sender, EventArgs e)
        {
            //object for the Identifying areas class
            IdentifyingAreas ia = new IdentifyingAreas();

            //shows the Identifying areas form
            ia.ShowDialog();

            //close the current/dewey form
            this.Close();
        }
    }
}
