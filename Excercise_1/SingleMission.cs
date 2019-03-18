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
        public double Calculate(double val)
        {
            double res;
            res = delMis(val);
            OnCalculate?.Invoke(this, res);
            return res;
        }
    }
}
