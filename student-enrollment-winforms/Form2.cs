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
    public partial class Form2 : Form
    {
        Student theStudent = new Student();
        

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtStratum.Text == "" || txtCredits.Text == "")
            {
                errorNull.SetError(txtName, "Debe ingresar un nombre de estudiante");
                errorNull.SetError(txtStratum, "Debe ingresar el estrato");
                errorNull.SetError(txtCredits, "Debe ingresar un número de creditos");
                return;
            }
            int Stratum;
            int Credits;

            if (!int.TryParse(txtStratum.Text, out Stratum) || !int.TryParse(txtCredits.Text, out Credits))
            {
                errorNull.SetError(txtStratum, "Debe ingresar un número de estrato");
                errorNull.SetError(txtCredits, "Debe ingresar un número de creditos");
                return;
            }

            theStudent.Name = txtName.Text;
            theStudent.Stratum = Convert.ToInt32(txtStratum.Text);
            theStudent.Credits = Convert.ToInt32(txtCredits.Text);

            Form3 enrollmentSimulator = new Form3(theStudent.Name, theStudent.Stratum, theStudent.Credits);
            enrollmentSimulator.Show();
            this.Hide();
        }
    }
}
