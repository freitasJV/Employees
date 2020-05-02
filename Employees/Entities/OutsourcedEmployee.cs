namespace Employees.Entities
{
    class OutsourcedEmployee : Employee
    {
        private static readonly double TaxaDeTerceiros = 1.1;
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * TaxaDeTerceiros;
        }
    }
}
