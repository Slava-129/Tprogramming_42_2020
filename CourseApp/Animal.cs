using System;

namespace CourseApp
{
        public abstract class Animal
        {
            private string name;
            private string breed;
            private int age;

            public Animal()
            : this(" ", " ", 0)
            {
            }

            public Animal(string new_name)
            : this(new_name, " ", 0)
            {
            }

            public Animal(string new_name, string new_breed)
            : this(new_name, new_breed, 0)
            {
            }

            public Animal(string new_name, string new_breed, int new_age)
            {
                this.Name = new_name;
                this.Breed = new_breed;
                this.Age = new_age;
            }

            public virtual string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    if (value.Length < 3)
                    {
                        name = "Неизвестно";
                    }
                    else
                    {
                        name = value;
                    }
                }
            }

            public virtual string Breed
            {
                get
                {
                    return breed;
                }

                set
                {
                    if (value.Length < 3)
                    {
                        breed = "Неизвестна";
                    }
                    else
                    {
                        breed = value;
                    }
                }
            }

            public virtual int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Возраст неизвестен");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }

            public virtual string DisplayInf() => $"Name: {Name}  Breed: {Breed}  Age: {Age}";

            public virtual void EditInf(string new_name, string new_breed, int new_age)
            {
                    Name = new_name;
                    Breed = new_breed;
                    Age = new_age;
            }

            public abstract string Vois();
        }
}