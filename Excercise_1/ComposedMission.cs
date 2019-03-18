using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private string name;
        private string type = "Composed";
        private List<DelegateMis> delMisList = new List<DelegateMis>();
        public event EventHandler<double> OnCalculate;

        // constructor
        public ComposedMission(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public string Type
        {
            get { return type; }
        }

        // a function that adds a delegate to the delegate-list (in functional-prog way)
        public ComposedMission Add(DelegateMis delMis)
        {
            delMisList.Add(delMis);
            return this;
        }
        // calculates the value of a given parameter, according to the delegate
        public double Calculate(double val)
        {
            double res = val;
            foreach (DelegateMis mis in delMisList)
            {
                res = mis(res);    
            }
            // notify about the event
            OnCalculate?.Invoke(this, res);
            return res;
        }
    }
}
