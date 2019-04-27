using System.Collections.Generic;
using System.Linq;
using Questions.Conditions.Evaluations;

namespace Questions.Conditions {
    public class ConditionGroup {
        private readonly List<Condition> conditions;
        public int lenght {
            get { return conditions.Count; }
        }

        public ConditionGroup() {
            conditions = null;
        }
        
        public ConditionGroup(string conditionsString) {
            conditions=new List<Condition>();
            foreach (var s in conditionsString.Split('|')) {
                var cond=new Condition(s);
                conditions.Add(cond);
            }
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