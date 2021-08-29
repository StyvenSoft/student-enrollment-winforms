using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_enrollment_winforms
{
    public class Student
    {
        private string name;
        private int stratum;
        private int credits;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Stratum
        {
            get
            {
                return stratum;
            }

            set
            {
                stratum = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }
    }
}
