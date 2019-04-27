using System.Collections.Generic;
using System.Linq;
using PlayerManagement.States;
using Questions.Conditions.Evaluations;

namespace Questions.Conditions {
    public class ConditionGroup {
        public List<Condition> conditions { get; set; }

        public int lenght {
            get { return conditions.Count; }
        }
        
        public ConditionGroup() {
            
        }

        public bool check(IEnumerable<PlayerState> states) {
            return conditions == null ||
                   conditions.Any(condition => condition.check(states));
        }
        
        public override string ToString() {           
            if (conditions == null || conditions.Count == 0) {
                return "No Conditions";
            }
            
            var s = "";
            for (var i = 0; i < conditions.Count; i++) {
                s += "\n "+ i + ") " + conditions[i].ToString();
            }

            return s;
        }
    }
}