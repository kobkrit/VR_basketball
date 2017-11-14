using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayAtEnd : MonoBehaviour {
	Text text;
	ScoreAbsorber scoreAbsorber;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		scoreAbsorber = FindObjectOfType<ScoreAbsorber> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = "Score: "+scoreAbsorber.score;
	}
}
