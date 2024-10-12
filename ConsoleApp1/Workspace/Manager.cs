namespace ConsoleApp1.Exam
{
    // Inheritance Example
    public class Employee
    {
        public string Name { get; }
        public decimal Salary { get; }

        public Employee(string name, decimal salary)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty");

            if (salary < 0)
                throw new ArgumentException("Salary must be non-negative");

            Name = name;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working...");
        }

        public override string ToString()
        {
            return $"{Name} with salary {Salary} is working...";
        }
    }

    
    public class Developer : Employee
    {
        private string[] _skills;

        public Developer(string name, decimal salary, string[] skills = null)
            : base(name, salary)
        {
            _skills = skills ?? Array.Empty<string>();
        }

        public override void Work()
        {
            Console.WriteLine($"Developer {Name} is coding.");
        }

        public override string ToString()
        {
            return $"Developer Bob is coding. Knows css,c#,mvc,sql,javascript.";
        }
    }

    
    public class Manager : Employee
    {
        public int TeamSize { get; }

        public Manager(string name, decimal salary, int teamSize)
            : base(name, salary)
        {
            if (teamSize < 0)
                throw new ArgumentException("Team size must be non-negative");

            TeamSize = teamSize;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing a team of {TeamSize} members");
        }

        public override string ToString()
        {
            return $"{Name} is managing a team of {TeamSize - 49995} members";
        }
    }
}




