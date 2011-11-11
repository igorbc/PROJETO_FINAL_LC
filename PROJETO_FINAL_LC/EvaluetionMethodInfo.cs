using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROJETO_FINAL_LC
{
    public class EvaluetionMethodInfo
    {
        private EvaluetionMethod evaluetionMethod;
        private float lowerLimit;
        private float higherLimit;
        private float step;

        public EvaluetionMethodInfo(EvaluetionMethod evaluetionMethod, float lowerLimit,
                                    float higherLimit, float step)
        {
            this.evaluetionMethod = evaluetionMethod;
            this.lowerLimit = lowerLimit;
            this.higherLimit = higherLimit;
            this.step = step;
        }

        public EvaluetionMethod getEvaluetionMethod()
        {
            return evaluetionMethod;
        }

        public float getLowerLimit()
        {
            return lowerLimit;
        }

        public float getHigherLimit()
        {
            return higherLimit;
        }

        public float getStep()
        {
            return step;
        }
    }
}
