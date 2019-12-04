using System;

namespace tech_test_ps
{
    public class UserInterpret : Expression
    {
        public override void Interpret(AppContext context)
        {
            string location = context.UserInput.EmployeesLocation;

            bool isvalidLocation = Enum.IsDefined(typeof(Country), location.ToLower());
            int.TryParse(context.UserInput.HoursRate, out int hoursRate);
            int.TryParse(context.UserInput.HoursRate, out int hoursWorked);

            isValid = (hoursRate != 0 && hoursWorked != 0 && isvalidLocation);
        }
    }

}
    


