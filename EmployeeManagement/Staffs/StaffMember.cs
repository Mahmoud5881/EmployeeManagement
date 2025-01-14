namespace EmployeeManagement.Staff
{

    public abstract class StaffMember
    {
        protected int EmployeeId;
        protected string Name;
        protected string Phone;
        protected string Email;
        protected Department department;

        public abstract string Print();

        public abstract double Pay();
    }
}