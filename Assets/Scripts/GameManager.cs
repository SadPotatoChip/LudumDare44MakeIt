using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CSVReader;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	private void Awake() {
		instance = this;
		var qs=CSVReader.CSVReader.readQuestionsFromFile("test.csv");

		foreach (var q in qs) {
		   Debug.Log(q.ToString());
		}
	}
}
