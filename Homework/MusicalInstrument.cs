using System;


namespace Homework
{
    internal class MusicalInstrument
    {
        protected string name; //название устройства
        protected int year; //год выпуска
        public string Name { get { return name; } set { name = value; } }
        public int Year { get { return year; } set { year = value; } }
        public MusicalInstrument()
        { 
            name = null; 
            year = 0;
        }
        public MusicalInstrument(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
        public virtual void Sound() 
        {
            Console.WriteLine($"Play sound on {name}");
        }
        public virtual void Show() 
        {
            Console.WriteLine($"Show information about {name}");
        }
        public virtual void Describe() 
        {
            Console.WriteLine($"Description of {name}");
        }
        public virtual void History() 
        {
            Console.WriteLine($"History about {name}");
        }
    }
    internal class Violin : MusicalInstrument
    {
        private string material;
        public string Material { get { return material; } set { material = value; } }
        public Violin()
        {
            material = null;
        }
        public Violin(string name, int year, string material) : base(name, year)
        {
            this.material = material;
        }
        public override void Sound() 
        {
            Console.WriteLine($"Проигрываю звук на {name}");
        }
        public override void Describe() 
        {
            Console.WriteLine($"Проигрываю звук на {name}");
        }
        public override void History() 
        {
            Console.WriteLine($"Проигрываю звук на {name}");
        }
    }
    internal class Trombone : MusicalInstrument
    {
        private string type;
        public string Type { get { return type; } set { type = value; } }
        public Trombone()
        {
            type = null;
        }
        public Trombone(string name, int year, string type) : base(name, year)
        { 
            this.type = type; 
        }
        public override void Sound() { }
        public override void Describe() { }
        public override void History() { }
    }
    internal class Ukulele : MusicalInstrument
    {
        private string numOfStrings;
        public string NumberOfStrings { get { return numOfStrings; } set { numOfStrings = value; } }
        public Ukulele()
        {
            numOfStrings = null;
        }
        public Ukulele(string name, int year, string numOfStrings) : base(name, year)
        {
            this.numOfStrings = numOfStrings;
        }
        public override void Sound() { }
        public override void Describe() { }
        public override void History() { }
    }
    internal class Cello : MusicalInstrument
    {
        private string size;
        public string Size { get { return size; } set { size = value; } }
        public Cello()
        {
            size = null;
        }
        public Cello(string name, int year, string size) : base(name, year)
        {
            this.size = size;
        }
        public override void Sound() { }
        public override void Describe() { }
        public override void History() { }
    }
}
