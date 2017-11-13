using UnityEngine;
using System.Collections;

public class DetectCollision : MonoBehaviour {

	public int scoreToIncrease = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c){
		ScoreCount sc = FindObjectOfType<ScoreCount> ();
		sc.IncreaseScore (scoreToIncrease);
	}
}
