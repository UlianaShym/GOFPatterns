namespace GofPatternsFun.Creational.Prototype
{
    abstract class EmployeePrototype
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public abstract EmployeePrototype Clone();

        public abstract string GetDetails();
    }
}
