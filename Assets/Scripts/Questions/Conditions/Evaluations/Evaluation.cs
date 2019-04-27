using System;
using System.Linq;

namespace Questions.Conditions.Evaluations {
    public class Evaluation {
        public bool isTrue { get; set; }
        public string name { get; set; }
        public ValueComparisonType comparisonType { get; set; }
        public int value { get; set; }

        public Evaluation() {
           
        }

        public virtual bool check(PlayerState state) {
            switch (comparisonType) {
                case ValueComparisonType.None:
                    return state.isTrue == isTrue;
                case ValueComparisonType.Equal:
                    return state.value == value;
                case ValueComparisonType.LessThan:
                    return state.value > value;
                case ValueComparisonType.GreaterThan:
                    return state.value < value;
            }

            throw new NotSupportedException("Unsupported Comparison Type Encountered");
        }
        
        public override string ToString() {
            var s = "";
            if (comparisonType == ValueComparisonType.None) {
                s += name + " is " + isTrue;
            } else {
                s += name + " " + comparisonType + " " + value;
            }

            return s;
        }
    }
}