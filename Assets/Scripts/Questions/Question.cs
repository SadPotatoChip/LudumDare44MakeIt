using System;
using System.Collections.Generic;
using System.Linq;
using FLLib;
using PlayerManagement;
using Questions.Conditions;

namespace Questions {
    public class Question {

        public string id { get; set; }
        public string nextId { get; set; }
        public IntRange possibleAge { get; set; }
        
        public int chance { get; set; }
        public string text { get; set; }
        public List<Answer> answers { get; set; }
        public ConditionGroup conditionGroup { get; set; }

        public int numberOfAnswers;

        public Question() {
            
        }

        public bool isViable() {
            return possibleAge.contains(PlayerManager.instance.player.age);
            //TODO condition checks
        }

        public override string ToString() {
            var s = "";
            s += "Text: " + text +"\n";
            s += "PossibleAge: " + possibleAge.min + "->" + possibleAge.max +"\n";
            s += "Answers: \n";
            for (var i = 0; i < answers.Count; i++) {
                s += i + ") " + answers[i].ToString();
            }
            s += "Conditions: ";
            s += conditionGroup.ToString();

            return s;
        }
    }
}