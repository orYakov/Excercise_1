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
        //private DelegateMis delMis;
        private List<DelegateMis> delMisList = new List<DelegateMis>();
        public event EventHandler<double> OnCalculate;

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

        public ComposedMission Add(DelegateMis delMis)
        {
            delMisList.Add(delMis);
            return this;
        }
        public double Calculate(double val)
        {
            double res = val;
            foreach (DelegateMis mis in delMisList)
            {
                res = mis(res);    
            }
            OnCalculate?.Invoke(this, res);
            return res;
            //for each res
        }
    }
}
