using System;

namespace tech_test_ps
{
    public class UserInterpret : Expression
    {
        public override void Interpret(AppContext context)
        {
            string location = context.UserInput.EmployeesLocation;

            bool isvalidLocation = Enum.IsDefined(typeof(Countries), location.ToLower());
            int.TryParse(context.UserInput.StrHoursRate, out int hoursRate);
            int.TryParse(context.UserInput.StrHoursWorked, out int hoursWorked);

            context.UserInput.HoursRate = hoursRate;
            context.UserInput.HoursWorked = hoursWorked;

            isValid = (hoursRate != 0 && hoursWorked != 0 && isvalidLocation);
        }
    }

}
    


