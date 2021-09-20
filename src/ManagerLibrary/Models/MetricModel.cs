using System;

namespace ManagerLibrary.Models
{
    public class MetricModel : IComparable
    {
        /// <summary>
        /// The integer identifier of the word
        /// whose accuracy is represented.
        /// </summary>
        public int WordID { get; set; }

        /// <summary>
        /// The overall accuracy of the word since 
        /// it's beeb created.
        /// </summary>
        public double OverallAcc { get; set; }

        /// <summary>
        /// The current accuracy, repreesnting the accuracy
        /// of latest several records of the word.
        /// </summary>
        public double CurrentAcc { get; set; }

        public MetricModel()
        {

        }

        public MetricModel(int wordId, double overallAcc, double curAcc)
        {
            WordID = wordId;
            OverallAcc = overallAcc;
            CurrentAcc = curAcc;
        }

        /// <summary>
        /// Comparation bewteen AccuracyModel object.
        /// CurrentAcc will be compared first. If both of them have 
        /// same CurrentAcc, OverallAcc will be then taken into consideration.
        /// </summary>
        /// <param name="obj">Another Accuracy Model object.</param>
        /// <returns>1 or -1</returns>
        public int CompareTo(object obj)
        {
            MetricModel other = (MetricModel)obj;
            if (this.CurrentAcc != other.CurrentAcc)
            {
                return this.CurrentAcc.CompareTo(other.CurrentAcc);
            }
            else
            {
                return this.OverallAcc.CompareTo(other.OverallAcc);
            }
        }

        public override string ToString()
        {
            string ret = String.Format(
                "Accuracy (Overall): {0:P2} | Accuary (Last 3 Tests): {1:P2}", 
                OverallAcc, CurrentAcc);
            return ret;
        }
    }
}
