using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private string name;
        private string type = "Single";
        private DelegateMis delMis;
        public event EventHandler<double> OnCalculate;

        // constructor
        public SingleMission(DelegateMis delMis, string name)
        {
            this.name = name;
            this.delMis += delMis;
        }

        

        public string Name
        {
            get { return name; }
        }

        public string Type
        {
            get { return type; }
        }
        // calculates the value of a given parameter, according to the delegate
        public double Calculate(double val)
        {
            double res;
            res = delMis(val);
            // notify about the event
            OnCalculate?.Invoke(this, res);
            return res;
        }
    }
}
