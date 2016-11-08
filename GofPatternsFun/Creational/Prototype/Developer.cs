namespace GofPatternsFun.Creational.Prototype
{
    class Developer : EmployeePrototype
    {
        public string PreferredLanguage { get; set; }

        public override EmployeePrototype Clone()
        {
            return (EmployeePrototype)MemberwiseClone();
        }

        public override string GetDetails()
        {
            return string.Format("Developer {0} - {1} - {2}", Name, Role, PreferredLanguage);
        }
    }
}
