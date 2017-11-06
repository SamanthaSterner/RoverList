using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            RoverList list = new RoverList();
            list.Add("Hello");
            list.Add("World");
            list.Add("It's");
            list.Add("nice");
            list.Add("to");
            list.Add("meet");
            list.Add("you");

            list.ListNodes();

            // TODO:  Print out the list

            // TODO:  Remove every 3rd word
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
