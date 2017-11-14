using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour {

	public int scoreToIncrease = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider c){
		ScoreCount scoreCount = FindObjectOfType<ScoreCount> ();
		scoreCount.IncreaseScore (scoreToIncrease);
	}
}
