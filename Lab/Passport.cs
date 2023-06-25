using System;
using System.Collections.Generic;

namespace Lab
{
    internal class Passport
    {
        private string country_code; //код страны
        private string name; //имя владельца
        private string surname; //фамилия владельца
        private char sex; //пол
        private string birthdate; //дата рождения
        private string birthplace; //место рождения
        private string issue_date; //дата выдачи
        private string expiry_date; //конец срока действия
        public Passport(string country_code = null, string name = null, string surname = null, char sex = ' ', 
            string birthdate = null, string birthplace = null, string issue_date = null, string expiry_date = null)
        {
            CountryCode = country_code; 
            Name = name; 
            Surname = surname; 
            Sex = sex; 
            Birthdate = birthdate; 
            Birthplace = birthplace; 
            IssueDate = issue_date; 
            ExpiryDate = expiry_date; 
        }
        public virtual void Print()
        {
            Console.WriteLine($"Country code: {country_code}\nName: {name}\nSurname: {surname}\nSex: {sex}" +
                $"\nDate of birth: {birthdate}\nPlace of birth: {birthplace}\nDate of issue: {issue_date}\nDate of expiry: {expiry_date}");
        }
        public string CountryCode
        {
            get
            {
                return country_code;
            }
            set
            {
                try
                {
                    if (value.Length != 3) 
                    {
                        throw new Exception("Country code is three letters long");
                    }
                    else 
                    { 
                        country_code = value; 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set 
            {
                try
                {
                    string data = value.ToString();
                    if (int.TryParse(data, out int not_letters)) //Ввод числа вместо имени
                    {
                        throw new Exception("Name cannot be an Integer or a number");
                    }
                    else
                    {
                        name = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string Surname
        {
            get
            { 
                return surname;
            }
            set
            {
                try
                {
                    string data = value.ToString();
                    if (int.TryParse(data, out int not_letters)) //Ввод числа вместо фамилии
                    {
                        throw new Exception("Surname cannot be an Integer or a number");
                    }
                    else
                    {
                        surname = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public char Sex
        {
            get
            {
                return sex;
            }
            set
            {
                try
                {
                    if(value != 'M' && value != 'F')
                    {
                        throw new Exception("Please write M (male) or F (female) in the sex field");
                    }
                    else
                    {
                        sex = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string Birthdate
        {
            get
            { 
                return birthdate;
            }
            set
            {
                try
                {
                    string date = value.ToString();
                    if(!DateTime.TryParse(date, out DateTime not_valid)) //Проверка ввода даты
                    {
                        throw new Exception("Date of birth is not valid");
                    }
                    else
                    {
                        this.birthdate = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string Birthplace
        {
            get
            { 
                return birthplace;
            }
            set
            {
                try
                {
                    string data = value.ToString();
                    if (int.TryParse(data, out int not_letters)) //Ввод числа вместо букв и знаков пунктуации
                    {
                        throw new Exception("Place of birth cannot be an Integer or a number");
                    }
                    else if(value.Length > 50)
                    {
                        throw new Exception("Too many letters in the field \"Place of birth\"");
                    }
                    else
                    {
                        birthplace = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string IssueDate
        {
            get
            {
                return issue_date;
            }
            set
            {
                try
                {
                    string date = value.ToString();
                    if (!DateTime.TryParse(date, out DateTime not_valid)) //Проверка ввода даты
                    {
                        throw new Exception("Date of issue is not valid");
                    }
                    else
                    {
                        issue_date = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string ExpiryDate
        {
            get
            { 
                return expiry_date;
            }
            set
            {
                try
                {
                    string date = value.ToString();
                    if (!DateTime.TryParse(date, out DateTime not_valid)) //Проверка ввода даты
                    {
                        throw new Exception("Date of expiry is not valid");
                    }
                    else
                    {
                        expiry_date = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
    }
    internal class ForeignPassport : Passport
    {
        private string number; //номер заграничного паспорта
        public ForeignPassport(string country_code, string name, string surname, char sex, string birthdate, string birthplace, 
            string issue_date, string expiry_date, string number = null) : base(country_code, name, surname, sex, birthdate,
                birthplace, issue_date, expiry_date)
        {
            Number = number;
            Visas = new List<Visa>(); //визы
        }
        public void AddVisa(Visa visa) //Добавить новую визу
        {
            Visas.Add(visa);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Number: {number}\n\n");
            Console.WriteLine("Visas: ");
            foreach(Visa visa in Visas) //Отобразить визы
            {
                Console.WriteLine(visa.ToString());
                Console.WriteLine();
            }
        }
        public string Number
        { 
            get 
            { 
                return number; 
            } 
            set
            { 
                try
                {
                    string data = value.ToString();
                    if (value.Length != 8)
                    {
                        throw new Exception("Passport number length cannot be less or greater than 8");
                    }
                    else if (int.TryParse(data, out int only_digits)) //Если забыли ввести первые две буквы;)
                    {
                        throw new Exception("First two signs of the passport number must be letters");
                    }
                    else
                    {
                        number = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public List<Visa> Visas 
        {
            get; set;
        }
    }
    internal struct Visa
    {
        private string country; //страна пребывания
        private string visa_number; //номер визы
        private string control_number; //контрольный номер
        private string issue_date; //дата выдачи
        private string expiry_date; //конец срока действия
        public Visa(string country, string visa_number, string control_number, string issue_date, string expiry_date) : this()
        {
            Country = country;
            VisaNumber = visa_number;
            ControlNumber = control_number;
            IssueDate = issue_date;
            ExpiryDate = expiry_date;
        }
        public override string ToString()
        {
            return $"Country of residence: {country}\nNumber: {visa_number}\nControl number: {control_number}\nDate of issue: {issue_date}\nDate of expire: {expiry_date}";
        }
        public string Country
        {
            get 
            { 
                return country; 
            } 
            set 
            {
                try
                {
                    string data = value.ToString();
                    if (int.TryParse(data, out int not_letters)) //Ввод числа вместо имени
                    {
                        throw new Exception("Name cannot be an Integer or a number");
                    }
                    else
                    {
                        country = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string VisaNumber
        {
            get 
            { 
                return visa_number; 
            } 
            set 
            {
                try
                {
                    string data = value.ToString();
                    if (value.Length != 8)
                    {
                        throw new Exception("Control number length cannot be less or greater than 8");
                    }
                    else if (int.TryParse(data, out int only_digits)) //Если забыли ввести букву в начале;)
                    {
                        throw new Exception("First sign of the visa number must be a letter");
                    }
                    else
                    {
                        visa_number = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string ControlNumber
        {
            get 
            { 
                return control_number; 
            } 
            set 
            {
                try
                {
                    string data = value.ToString();
                    if (value.Length != 14)
                    {
                        throw new Exception("Control number length cannot be less or greater than 14");
                    }
                    else if (!long.TryParse(data, out long not_digits)) //Если ввели буквы вместо цифр;)
                    {
                        throw new Exception("Control number cannot contain letters.");
                    }
                    else
                    {
                        control_number = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string IssueDate
        {
            get
            {
                return issue_date;
            }
            set
            {
                try
                {
                    string date = value.ToString();
                    if (!DateTime.TryParse(date, out DateTime not_valid)) //Проверка ввода даты
                    {
                        throw new Exception("Date of issue is not valid");
                    }
                    else
                    {
                        issue_date = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
        public string ExpiryDate
        {
            get
            {
                return expiry_date;
            }
            set
            {
                try
                {
                    string date = value.ToString();
                    if (!DateTime.TryParse(date, out DateTime not_valid)) //Проверка ввода даты
                    {
                        throw new Exception("Date of expiry is not valid");
                    }
                    else
                    {
                        expiry_date = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
    }
}