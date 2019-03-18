using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;//
//
namespace Excercise_1
{

    // a delegate definition for the namespace
    public delegate double DelegateMis(double val);
    public class FunctionsContainer
    {
        private Dictionary<string, DelegateMis> dictionary = new Dictionary<string, DelegateMis>();

        // constructor
        public FunctionsContainer() {}
        
        // indexer
        public DelegateMis this[string funcName]
        {
            get
            {
                /*
                if the function name doesn't exist, add it with a function that doesn't
                change the parameter's value 
                */
                if (!dictionary.ContainsKey(funcName))
                {
                    this[funcName] = val => val;
                }
                return dictionary[funcName];
            }

            set { dictionary[funcName] = value; }
        }

        // a function that returns a list of all the mission names
        public List<string> getAllMissions()
        {
            return new List<string>(dictionary.Keys);
        }

    }
}
