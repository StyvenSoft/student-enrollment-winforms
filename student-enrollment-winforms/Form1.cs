using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_enrollment_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String passwordDefault = "123";
            if(txtPassword.Text == passwordDefault)
            {
                Form2 registrationSimulator = new Form2();
                registrationSimulator.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("¡La contraseña es incorrecta!");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
