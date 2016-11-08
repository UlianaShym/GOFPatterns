namespace GofPatternsFun.Creational.Prototype
{
    class TechWriter : EmployeePrototype
    {
        public int WordsPerMinute { get; set; }

        public override EmployeePrototype Clone()
        {
            return (EmployeePrototype)MemberwiseClone();
        }

        public override string GetDetails()
        {
            return string.Format("TechWriter {0} - {1} - {2}wpm", Name, Role, WordsPerMinute);
        }
    }
}
