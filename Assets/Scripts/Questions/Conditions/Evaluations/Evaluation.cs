using System;
using System.Linq;

namespace Questions.Conditions.Evaluations {
    public class Evaluation { 
        public readonly bool isTrue=true;
        public readonly string name;
        public readonly ValueComparisonType comparisonType=ValueComparisonType.None;
        public readonly int comparisonValue;

        public Evaluation(string tagString) {
            if (string.IsNullOrEmpty(tagString)) {
                return;
            }

            if (tagString[0] == '~') {
                isTrue = false;
                tagString=tagString.Remove(0,1);
            }

            name = tagString;
                       
            var eqList = tagString.Split('=');
            if (eqList.Count() > 1) {
                name = eqList[0];
                comparisonValue=int.Parse(eqList[1]);
                comparisonType = ValueComparisonType.Equal;
                return;
            }
            var lessThanList = tagString.Split('<');
            if (lessThanList.Count() > 1) {
                name = lessThanList[0];
                comparisonValue=int.Parse(lessThanList[1]);
                comparisonType = ValueComparisonType.LessThan;
            }
            var greaterThanList = tagString.Split('>');
            if (greaterThanList.Count() > 1) {
                name = greaterThanList[0];
                comparisonValue=int.Parse(greaterThanList[1]);
                comparisonType = ValueComparisonType.GreaterThan;
            }
            
        }

        public virtual bool check(PlayerState state) {
            switch (comparisonType) {
                case ValueComparisonType.None:
                    return state.isTrue == isTrue;
                case ValueComparisonType.Equal:
                    return state.value == comparisonValue;
                case ValueComparisonType.LessThan:
                    return state.value > comparisonValue;
                case ValueComparisonType.GreaterThan:
                    return state.value < comparisonValue;
            }

            throw new NotSupportedException("Unsupported Comparison Type Encountered");
        }
        
        public override string ToString() {
            var s = "";
            if (comparisonType == ValueComparisonType.None) {
                s += name + " is " + isTrue;
            } else {
                s += name + " " + comparisonType + " " + comparisonValue;
            }

            return s;
        }
    }
}