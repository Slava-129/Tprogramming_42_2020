using System;

namespace CourseApp
{
    public class Cat : Animal
    {
        public Cat()
        : base()
        {
        }

        public Cat(string new_name)
        : base(new_name)
        {
        }

        public Cat(string new_name, string new_breed)
        : base(new_name, new_breed)
        {
        }

        public Cat(string new_name, string new_breed, int new_age)
        : base(new_name, new_breed, new_age)
        {
        }

        public override string DisplayInf() => $"Cat:\nName: {Name}  Breed: {Breed}  Age: {Age}";

        public override void EditInf(string new_name, string new_breed, int new_age)
        {
            base.EditInf(new_name, new_breed, new_age);
        }

        public override string Vois() => "*Мяу*\n";
    }
}