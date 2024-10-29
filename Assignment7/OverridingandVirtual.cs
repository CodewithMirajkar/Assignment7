//using System;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
//    class Animal
//    {
//        public virtual void MakeSound()
//        {
//            Console.WriteLine("Animal makesound");
//        }
//    }
//    class Dog : Animal
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine("Dog Sound:bhurk");
//        }
//    }
//    class Cat : Animal
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine("Cat Sound : meows");
//        }
//    }
//    class Bird : Animal
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine("Bird Sound :chirp");
//        }
//    }



//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Animal animal = new Animal();
           
//            Animal dog = new Dog();
//            Animal cat = new Cat();
//            Animal bird = new Bird();
//            dog.MakeSound();
//            cat.MakeSound();
//            dog.MakeSound();
//            Console.ReadLine();
//        }
//    }
//}
