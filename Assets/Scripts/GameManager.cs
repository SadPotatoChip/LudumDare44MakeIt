using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PlayerManagement;
using UnityEngine;
using Readers;
using UIManager.QuestionAnswerUI;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	private void Awake() {
		instance = this;
		QAManager.instance.activeQuestions=JSONReader.readQuestionsFromFile("test.json");
		PlayerManager.instance.startGame();	
		QAManager.instance.nextQuestion();		
		Debug.Log(QAManager.instance.activeQuestions.First().ToString());
	}
}
