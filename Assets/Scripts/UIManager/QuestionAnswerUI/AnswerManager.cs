using PlayerManagement;
using Questions;
using TMPro;
using UIManager.StatusDisplay;
using UnityEngine;

namespace UIManager.QuestionAnswerUI {
    public class AnswerManager :MonoBehaviour{
        private Answer _answer;
        public TextMeshProUGUI text;
        public TextMeshProUGUI cost;
        public Answer answer {
            get { return _answer; }
            set { 
                _answer = value;
                text.text = value.text;
                cost.text = value.cost.ToString();
            }
        }

        public void onClick() {
            answer.applyToPlayer(PlayerManager.instance.player);
            StatusManager.instance.refresh(PlayerManager.instance.player);
            QAManager.instance.nextQuestion();
        }
    }
}