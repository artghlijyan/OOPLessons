using OOPLessons.BaseModels;
using OOPLessons.Models;

namespace OOPLessons
{
    static class SalaryCounter
    {
        private static double _ratio;

        private const double minSalary = 45000;

        public static double GetSalary(this Employee emp)
        {
            if (emp is BranchManager)
            {
                _ratio = 2;
                return emp.Salary = _ratio * minSalary;
            }
            else if (emp is Receptionist)
            {
                _ratio = 1.2;
                return emp.Salary = _ratio * minSalary;
            }
            else
            {
                return 0;
            }
        }
    }
}
