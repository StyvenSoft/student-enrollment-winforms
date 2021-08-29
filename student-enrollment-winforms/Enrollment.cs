using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_enrollment_winforms
{
    public class Enrollment
    {
        public int CalculateEnrollment(int socialStratum, int numberCredits)
        {
            int valueCredit = 112000;
            int totalEnronment = numberCredits * valueCredit;

            if (socialStratum == 1)
            {
                return totalEnronment / 2;
            } else
            {
                return totalEnronment;
            }
        }
    }
}
