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
    public partial class Form3 : Form
    {
        Student theStudent = new Student();
        Enrollment theEnrollment = new Enrollment();

        public Form3(String name, int stratum, int credits)
        {
            InitializeComponent();

            this.label1.Text = name;
            this.label2.Text = Convert.ToString(stratum);
            this.label3.Text = Convert.ToString(credits);

            this.label8.Text = theEnrollment.CalculateEnrollment(stratum, credits).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 registrationSimulator = new Form2();
            registrationSimulator.Show();
            this.Close();
        }
    }
}
