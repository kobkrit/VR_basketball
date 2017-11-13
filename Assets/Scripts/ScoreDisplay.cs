using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text text;
	ScoreCount scoreCount;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		scoreCount = FindObjectOfType<ScoreCount> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: "+scoreCount.score;
	}
}
