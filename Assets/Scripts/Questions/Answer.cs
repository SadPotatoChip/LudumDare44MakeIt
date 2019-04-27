using System;
using FLLib;
using PlayerManagement.AnswerEffectManagement;

namespace Questions {
    public class Answer {
        public string text { get; set; }
        public int cost{ get; set; }
        public AnswerEffectGroup answerEffectGroup{ get; set; }

        public Answer() {
            
        }
        
        public override string ToString() {
            var s = "";
            s += "\n Text: " + text;
            s += "\n Cost: " + cost +"\n";
            return s;
        }
    }
}