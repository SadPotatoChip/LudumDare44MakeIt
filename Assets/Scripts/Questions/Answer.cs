using System;
using FLLib;
using PlayerManagement;
using PlayerManagement.AnswerEffectManagement;

namespace Questions {
    public class Answer {
        public string text { get; set; }
        public int cost{ get; set; }
        public AnswerEffectGroup answerEffectGroup{ get; set; }

        public Answer() {
            
        }

        public void applyToPlayer(Player player) {
            player.age += cost;
            answerEffectGroup.applyToPlayer(player);
        }
        
        public override string ToString() {
            var s = "";
            s += "\n Text: " + text;
            s += "\n Cost: " + cost ;
            s += "\n Effects: \n";
            s += answerEffectGroup.ToString();
            return s;
        }
    }
}