using System.Collections.Generic;
using System.Linq;
using PlayerManagement.States;
using Questions.Conditions.Evaluations;

namespace Questions.Conditions {
    public class Condition {
        public List<Evaluation> evaluations { get; set; }

        public Condition() {
            
        }

        public bool check(IEnumerable<PlayerState> states) {
            return states.All(state => evaluations.All(e => e.name != state.name) || evaluations.Single(e => e.name.Equals(state.name)).check(state));
        }
        
        public override string ToString() {
            var s = "";
            for (var i = 0; i < evaluations.Count; i++) {
                s += "\n  "+i + ") " + evaluations.ElementAt(i).ToString();
            }

            return s;
        }
    }
}