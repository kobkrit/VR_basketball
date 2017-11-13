using UnityEngine;
using System.Collections;

public class ScoreCount : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void IncreaseScore(int increment){
		score+=increment;
		print ("The ball hit! Score is: "+score);
	}
}
