using System;

namespace tech_test_ps
{
    public class IrelandPayroll: IPayRollCountryState
    {
        public void ComputeTaxes()
        {
            Console.WriteLine("ok");
        }

        /// <summary>
        ///income tax at a rate of 25 % for the first €600 and 40 % thereafter
        /// </summary>
        /// <param name="incoming"></param>
        /// <returns></returns>
        public decimal CalculateincomeTaxRate(decimal incoming)
        {
            var IncomeTax = (incoming * 0.25m);
            if (incoming > 600)
            {
                IncomeTax = ((incoming - IncomeTax) * 0.40m) + IncomeTax;
            }
            return IncomeTax;
        }
        /// <summary>
        ///Given the employee is located in Ireland, a Universal social charge of 7 % is applied for the first €500 euro and 8 % thereafter
        /// </summary>
        /// <param name="incoming"></param>
        /// <returns></returns>
        public decimal CalculeteUniversalSocialCharge(decimal incoming)
        {
            var IncomeTax = (incoming * 0.07m);
            if (incoming > 500)
            {
                IncomeTax = ((incoming - IncomeTax) * 0.08m) + IncomeTax;
            }
            return IncomeTax;
        }
        /// <summary>
        ///Given the employee is located in Ireland, a compulsory pension contribution of 4 % is applied
        /// </summary>
        /// <param name="incoming"></param>
        /// <returns></returns>
        public decimal CompulsoryPension(decimal incoming)
        {
            return (incoming * 0.04m);
        }

    }

}
    


