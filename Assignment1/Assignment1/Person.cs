using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Person
    {
        internal int Age;
       private string Sub;
       static int cnt = 0;
      internal Person()
        {
            cnt++;
            if (cnt == 1)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak("Hello I am a Person");
                Console.WriteLine("Hello I am a Person");
            }
            
        }
        internal string sub
        {
            get
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(Sub);
                return Sub;
            }
            set
            {

                Sub = "Hello,I am a person";

            }
        }
        internal Person(int age)
        {
            setAge(age);
        }
        internal void setAge(int n)
        {
            Age = n;
           
        }

       
    }

    internal class Singleton
    {
    }
}
