using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	int currentScene; 
	public float timeTillNextLevel = 0.0f;

	// Use this for initialization
	void Start () {
		currentScene = SceneManager.GetActiveScene ().buildIndex;
	}
	
	public void MoveToNextScene(){
		SceneManager.LoadScene (currentScene + 1);
	}

	public void MoveToPreviousScene(){
		SceneManager.LoadScene (currentScene - 1);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (currentScene < 2) {
				MoveToNextScene ();
			} else {
				MoveToPreviousScene ();
			}
		}
		if (timeTillNextLevel > 0) {
			timeTillNextLevel -= Time.deltaTime;
			print ("Time Left:" + timeTillNextLevel);
			if (timeTillNextLevel < 0) {
				MoveToNextScene ();
			}
		}
	}
}
