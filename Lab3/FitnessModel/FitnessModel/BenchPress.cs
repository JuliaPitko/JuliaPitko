using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessModel
{
    public class BenchPress : ActionsBase
    {
        private double _iteration;

        public double Iteration 
        {
            get
            {
                return _iteration;
            }

            set
            {
                _iteration = ValueChecking(value);
            }
        }

        public BenchPress
         (
         double iteration,
         double weightPerson,
         double time,
         double distanceOrWeight
         )
        {
            Iteration = iteration;
            WeightPerson = weightPerson;
            Time = time;
            DistanceOrWeight = distanceOrWeight;
        }

        public BenchPress() { }

        public override double KkalCalculation()
        {
            return (DistanceOrWeight / WeightPerson) * Iteration * Time;
        }
    }
}
