using System;
using System.Collections.Generic;
using System.Linq;
using FLLib;
using PlayerManagement;
using Questions.Conditions;

namespace Questions {
    public class Question {

        public IntRange possibleAge { get; set; }
        public string title { get; set; }
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
            s += "<b>Title: " + title +"</b>\n";
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