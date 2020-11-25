using System;

namespace CourseApp
{
    public class Dog : Animal
    {
        public Dog()
        : base()
        {
        }

        public Dog(string new_name)
        : base(new_name)
        {
        }

        public Dog(string new_name, string new_breed)
        : base(new_name, new_breed)
        {
        }

        public Dog(string new_name, string new_breed, int new_age)
        : base(new_name, new_breed, new_age)
        {
        }

        public override string DisplayInf() => $"Dog:\nName: {Name}  Breed: {Breed}  Age: {Age}";

        public override void EditInf(string new_name, string new_breed, int new_age)
        {
            base.EditInf(new_name, new_breed, new_age);
        }

        public void EditAge(int new_age)
        {
            Age = new_age;
        }

        public string GetAge() => $"Age: {Age}\n";

        public override string Vois() => "*Гав*\n";
    }
}