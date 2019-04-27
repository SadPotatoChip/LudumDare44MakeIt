using Questions;
using TMPro;
using UnityEngine;

namespace UIManager.QuestionAnswerUI {
    public class AnswerManager :MonoBehaviour{
        private Answer _answer;
        public TextMeshProUGUI text;
        public Answer answer {
            get { return _answer; }
            set { 
                _answer = value;
                text.text = value.text;
            }
        }

        public void onClick() {
            Debug.Log(answer.answerEffectGroup.effects); 
        }
    }
}