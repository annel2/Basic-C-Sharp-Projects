namespace Overload129
{
    internal class Employee
    {
        public int employee1ID { get; set; }


        public static bool operator == (Employee employee1, Employee employee2)
        {
            if (employee1.employee1ID == employee2.employee1ID)

                return true;

            else
                return false;
        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            if (employee1.employee1ID == employee2.employee1ID)

                return false;

            else
                return true;
        }
    }
}