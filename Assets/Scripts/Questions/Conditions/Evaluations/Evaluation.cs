using System;
using System.Linq;
using PlayerManagement.States;

namespace Questions.Conditions.Evaluations {
    public class Evaluation {
        public bool isTrue { get; set; }

        private string _name;
        public string name {
            get { return name; }
            set { _name = value.ToLower(); }
        }
        public ValueComparisonType comparisonType { get; set; }
        public int value { get; set; }

        public Evaluation() {
           
        }

        public virtual bool check(PlayerState state) {
            switch (comparisonType) {
                case ValueComparisonType.None:
                    return state.isTrue == isTrue;
                case ValueComparisonType.Equal:
                    return state.amount == value;
                case ValueComparisonType.LessThan:
                    return state.amount > value;
                case ValueComparisonType.GreaterThan:
                    return state.amount < value;
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