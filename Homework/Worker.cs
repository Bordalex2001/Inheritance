using System;

namespace Homework
{
    internal abstract class Worker
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }
        public Worker() 
        { 
            name = null;
        }
        public Worker(string name)
        { 
            this.name = name; 
        }
        public abstract void Print();
    }
    internal class President : Worker
    {
        private string republic;
        public string Republic
        {
            get { return republic; } set { republic = value; }
        }
        public President()
        {
            republic = null;
        }
        public President(string name, string republic) : base(name)
        {
            this.republic = republic;
        }
        public override void Print() 
        {
            Console.WriteLine($"{name} is the president of the republic of {republic}.");
        }
    }
    internal class Security : Worker
    {
        private string security_level;
        public string SecurityLevel
        {
            get { return security_level; } set { security_level = value; }
        }
        public Security()
        {
            security_level = null;
        }
        public Security(string name, string security_level) : base(name) 
        { 
            this.security_level = security_level;
        }
        public override void Print() 
        {
            Console.WriteLine($"Guard {name} has {security_level} security level.");
        }
    }
    internal class Manager : Worker
    {
        private string department;
        public string Department
        {
            set { department = value; } get { return department; }
        }
        public Manager()
        {
            department = null;
        }
        public Manager(string name, string department) : base(name)
        {
            this.department = department;
        }
        public override void Print() 
        {
            Console.WriteLine($"Manager {name} rules the {department} department.");
        }
    }
    internal class Engineer : Worker
    {
        private string specialization;
        public string Specialization
        {
            get { return specialization; } set { specialization = value; }
        }
        public Engineer()
        {
            specialization = null;
        }
        public Engineer(string name, string specialization) : base(name)
        {
            this.specialization = specialization;
        }
        public override void Print() 
        { 
            Console.WriteLine($"Engineer {name} specializes in {specialization}");
        }
    }
}