using System.Collections.Generic;
using System.Linq;
using Questions.Conditions.Evaluations;

namespace Questions.Conditions {
    public class Condition {
        private readonly Dictionary<string, Evaluation> elements;

        public Condition(string stringOfElements) {
            this.elements=new Dictionary<string, Evaluation>();
            var tagStrings=stringOfElements.Split('&');
            foreach (var s in tagStrings) {
                var t = new Evaluation(s);
                elements.Add(t.name, t);
            }
        }

        public bool check(IEnumerable<PlayerState> states) {
            return states.All(state => !elements.ContainsKey(state.name) || elements[state.name].check(state));
        }
        
        public override string ToString() {
            var s = "";
            for (var i = 0; i < elements.Count; i++) {
                s += "\n  "+i + ") " + elements.ElementAt(i).Value.ToString();
            }

            return s;
        }
    }
}