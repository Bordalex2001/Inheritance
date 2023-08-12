using System;

namespace Homework
{
    internal class Device
    {
        private string name; //название устройства
        private int year; //год выпуска
        public int Year { get { return year; } set { year = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Device() 
        {
            name = null; 
            year = 0;
        }
        public Device(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
        public virtual void Sound() { }
        public virtual void Show() { }
        public virtual void Describe() { }
    }
    internal class Kettle : Device
    {
        private int capacity;
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public Kettle()
        {
            capacity = 0;
        }
        public Kettle(string name, int year, int capacity) : base(name, year)
        { 
            this.capacity = capacity; 
        }
        public override void Sound() { }
        public override void Show() { }
        public override void Describe() { }
    }
    internal class Microwave : Device 
    { 
        private int power;
        public int Power { get { return power; } set { power = value; } }
        public Microwave()
        {
            power = 0;
        }
        public Microwave(string name, int year, int power) : base(name, year)
        {
            this.power = power;
        }
        public override void Sound() { }
        public override void Show() { }
        public override void Describe() { }
    }
    internal class Car : Device 
    {
        private int speed;
        public int Speed { get { return speed;} set { speed = value; } }
        public Car()
        {
            speed = 0;
        }
        public Car(string name, int year, int speed) : base(name, year) 
        { 
            this.speed = speed; 
        }
        public override void Sound() { }
        public override void Show() { }
        public override void Describe() { }
    }
    internal class Steamer : Device 
    {
        private int passengers;
        public int Passengers { get { return passengers; } set { passengers = value; } }     
        public Steamer()
        {
            passengers = 0;
        }
        public Steamer(string name, int year, int passengers) : base(name, year)
        { 
            this.passengers = passengers;
        }
        public override void Sound() { }
        public override void Show() { }
        public override void Describe() { }
    }
}
