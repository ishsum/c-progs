using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Student:Person
    {
        internal Student()
        {
          setAge(21);
          ShowAge();

        }

        Student(int age):base(age)
        {

        }
        public void GotoClasses()
        {
            Console.WriteLine("I am going to class");

        }
        public void ShowAge()
        {
           
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("I am a Student,Good Morning.My age is" + Age);
            Console.WriteLine("I am a Student,Good Morning.");
            Console.WriteLine("My age is: " +Age + " years old");
        }
    }
}
