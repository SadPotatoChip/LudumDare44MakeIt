using System.Collections.Generic;
using System.Linq;
using PlayerManagement.PhaseManagment;
using Questions;
using Readers;
using TMPro;
using UnityEngine;

namespace UIManager.QuestionAnswerUI {
    public class QAManager : MonoBehaviour {
        public static QAManager instance;
        public List<GameObject> activeQuestionButtons;

        public Queue<Question> forcedQuestions;
        public List<Question> activeQuestions;
        
        public Question currentQuestion;
        
        public TextMeshProUGUI questionText;

        public Transform answerParent;
        public GameObject answerPrefab;

        private void Awake() {
            instance = this;
            activeQuestionButtons=new List<GameObject>();
        }

        public void loadPhase(Phase phase) {
            var forced = JSONReader.readQuestionsFromFile(phase.questionsPathForced);
            forcedQuestions=new Queue<Question>();
            foreach (var q in forced) {
                forcedQuestions.Enqueue(q);
            }
            activeQuestions =JSONReader.readQuestionsFromFile(phase.questionsPath);

            nextQuestion();
        }

        public void nextQuestion() {
            if (forcedQuestions != null && forcedQuestions.Count != 0) {
                displayQuestion(forcedQuestions.Dequeue());
            }           
        }
        
        private void displayQuestion(Question question) {
            foreach (var obj in activeQuestionButtons) {
                Destroy(obj);
            }
            currentQuestion = question;
            questionText.text = currentQuestion.text;
            foreach (var answer in currentQuestion.answers) {
                var answerObject=Instantiate(answerPrefab, answerParent);                              
                var answerManager = answerObject.GetComponent<AnswerManager>();
                answerManager.answer = answer;
                activeQuestionButtons.Add(answerObject);
            }
        }
    }
}