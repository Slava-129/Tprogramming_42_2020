using System;

namespace CourseApp
{
    public class Class
    {
        public class Dog
        {
            private string name;
            private string breed;
            private string age;

            public Dog()
            : this("Unknown")
            {
            }

            public Dog(string n)
            : this(n, "Unknown")
            {
            }

            public Dog(string n, string b)
            : this(n, b, "Unknown")
            {
            }

            public Dog(string n, string b, string a)
            {
                this.name = n;
                this.breed = b;
                this.age = a;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Name: {name}  Breed: {breed}  Age: {age}");
            }

            public void EditInfo(string new_name, string new_breed, string new_age)
            {
                if (new_name != " ")
                {
                    name = new_name;
                }

                if (new_breed != " ")
                {
                    breed = new_breed;
                }

                if (new_age != " ")
                {
                    age = new_age;
                }
            }
        }
    }
}