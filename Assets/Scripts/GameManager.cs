using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Readers;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	private void Awake() {
		instance = this;
		var qs=JSONReader.readQuestionsFromFile("test.json");

		foreach (var q in qs) {
		   Debug.Log(q.ToString());
		}
	}
}
