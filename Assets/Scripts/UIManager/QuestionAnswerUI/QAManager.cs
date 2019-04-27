using System.Collections.Generic;
using System.Linq;
using Questions;
using TMPro;
using UnityEngine;

namespace UIManager.QuestionAnswerUI {
    public class QAManager : MonoBehaviour {
        public static QAManager instance;

        public List<Question> activeQuestions;
        
        public Question currentQuestion;
        
        public TextMeshProUGUI titleText;
        public TextMeshProUGUI questionText;

        public Transform answerParent;
        public GameObject answerPrefab;

        private void Awake() {
            instance = this;
        }

        public void nextQuestion() {
            displayQuestion(activeQuestions.First());
        }
        
        private void displayQuestion(Question question) {
            currentQuestion = question;
            titleText.text = currentQuestion.title;
            questionText.text = currentQuestion.text;
            foreach (var answer in currentQuestion.answers) {
                var answerObject=Instantiate(answerPrefab, answerParent);                              
                var answerManager = answerObject.GetComponent<AnswerManager>();
                answerManager.answer = answer;
            }
        }
    }
}