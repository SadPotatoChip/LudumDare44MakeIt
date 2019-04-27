using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PlayerManagement;
using UnityEngine;
using Readers;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	private void Awake() {
		instance = this;
		var qs=JSONReader.readQuestionsFromFile("test.json");
		var player = new Player();
		qs.First().answers.First().answerEffectGroup.executeOnPlayer(player);
		
		
		foreach (var q in qs) {
		   Debug.Log(q.ToString());
		}
	}
}
