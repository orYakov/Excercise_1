using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;//

namespace Excercise_1
{

    public delegate double DelegateMis(double val);
    public class FunctionsContainer
    {
        private Dictionary<string, DelegateMis> dictionary = new Dictionary<string, DelegateMis>();

        public FunctionsContainer() {}
        
        public DelegateMis this[string funcName]
        {
            get
            {
                if (!dictionary.ContainsKey(funcName))
                {
                    this[funcName] = val => val;
                }
                return dictionary[funcName];
            }

            set { dictionary[funcName] = value; }
        }

        public List<string> getAllMissions()
        {
            return new List<string>(dictionary.Keys);
        }

    }
}
