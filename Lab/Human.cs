using System;

namespace Lab
{
    internal class Human
    {
        private string name;
        private string surname;
        private int age;
        public Human()
        {
            name = null;
            surname = null;
            age = 0;
        }
        public Human(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public virtual string ToString()
        {
            return $"Hello, my name is {name} {surname}, I am {age} years old.\n";
        }
    }
    class Builder : Human
    {
        private string category;
        public Builder()
        {
            category = null;
        }
        public Builder(string name, string surname, int age, string category) : base(name, surname, age)
        {
            this.category = category;
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $"I am a builder by the {category} category.";
        }
    }
    class Sailor : Human
    {
        private string rank;
        public Sailor()
        {
            rank = null;
        }
        public Sailor(string name, string surname, int age, string rank) : base(name, surname, age)
        {
            this.rank = rank;
        }
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $"I am a sailor by the rank of {rank}.";
        }
    }
    class Pilot : Human
    {
        private string plane;
        private string license;
        public Pilot()
        {
            plane = null;
            license = null;
        }
        public Pilot(string name, string surname, int age, string plane, string license) : base(name, surname, age)
        {
            this.plane = plane;
            this.license = license;
        }
        public string Plane
        {
            get { return plane; }
            set { plane = value; }
        }
        public string License
        {
            get { return license; }
            set { license = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $"I am a {plane} pilot with a {license} license.";
        }
    }
    class Doctor : Human
    {
        private string specialization;
        private int hospital;
        public Doctor()
        {
            specialization = null;
            hospital = 0;
        }
        public Doctor(string name, string surname, int age, string specialization, int hospital) : base(name, surname, age)
        {
            this.specialization = specialization;
            this.hospital = hospital;
        }
        public string Specialization
        {
            get { return specialization; } set { specialization = value; }
        }
        public int Hospital
        {
            get { return hospital; } set { hospital = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $"I am a doctor at hospital No.{hospital} with a specialization in {specialization}.";
        }
    }
}
