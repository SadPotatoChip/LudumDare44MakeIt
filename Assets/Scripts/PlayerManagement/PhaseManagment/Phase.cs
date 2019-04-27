using Boo.Lang;
using Questions;
using Questions.Conditions;

namespace PlayerManagement.PhaseManagment {
    public class Phase {
        public string name { get; set; }
        public string questionsPath { get; set; }
        public string questionsPathForced { get; set; }
        
        public ConditionGroup conditionGroup { get; set; }
    }
}