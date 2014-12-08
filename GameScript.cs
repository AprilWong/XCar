using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

	public float timeLeft;
	Text txt;

	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text> ();
		timeLeft = 200.0f;
		txt.text = "Time:" + timeLeft;
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		txt.text = "Time:" + (int)timeLeft;
		if (timeLeft < 0) {
			GameOver();
		}
	}

	void GameOver(){
		Application.LoadLevel("lose");
	}
}
