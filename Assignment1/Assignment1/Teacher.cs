using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Teacher : Person
    {
        private string subject;
       internal string Sub
        { 
            get
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak(subject);
                return subject;
            }
            set
            {
               
                    subject = "I am a Teacher";
                
            }
        }
       internal Teacher()
        {
            setAge(30);
            Sub = "30";
            Console.WriteLine(Sub);
            Explain();

        }
        public void Explain()
            {
            Console.WriteLine( "Explaination begins");
            }

    }

}
