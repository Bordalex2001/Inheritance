using System;

namespace Lab
{
    internal class Animal
    {
        private string name; //имя или кличка
        public Animal()
        {
            name = null;
        }
        public Animal(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; } set { name = value; }
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hey, my name is {name}.");
        }
    }
    internal class Tiger : Animal
    {
        private string color; //цвет или окрас
        public Tiger()
        {
            color = null;
        }
        public Tiger(string name, string color) : base(name)
        {
            this.color = color;
        }
        public string Color
        {
            get { return color; } set { color = value; }
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I'm a tiger with {color} color.");
        }
        public void Walk()
        {
            Console.Write("I walk the ground ");
        }
        public void Hunt()
        {
            Console.Write("and I hunt for prey.");
        }
    }
    internal class Crocodile : Animal
    {
        private double snout; //длина рыла
        public Crocodile()
        {
            snout = 0;
        }
        public Crocodile(string name, double snout) : base(name)
        {
            this.snout = snout;
        }
        public double Snout
        {
            get { return snout; } set { snout = value; }
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I'm a crocodile with snout {snout} centimeters long.");
        }
        public void Swim()
        {
            Console.Write("I swim in the water ");
        }
        public void Crawl()
        {
            Console.Write("and I crawl on the ground.");
        }
    }
    internal class Kangaroo : Animal
    {
        private double jump_length; //длина прыжка
        public Kangaroo()
        {
            jump_length = 0;
        }
        public Kangaroo(string name, double jump_length) : base(name)
        {
            this.jump_length = jump_length;
        }
        public double JumpLength
        {
            get { return jump_length; } set { jump_length = value; }
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I'm a kangaroo that jumps up to {jump_length} meters.");
        }
        public void Jump()
        {
            Console.Write("I jump enough wide and high.");
        }
    }
}
