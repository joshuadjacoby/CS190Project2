using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnoozeTimer : MonoBehaviour {
	float timer;
	static float maxTime = 17;
	bool textChanged;

	// Use this for initialization
	void Start () {
		timer = 0;
		textChanged = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!textChanged && timer >= maxTime) {
			GameObject.Find ("SpacebarText").GetComponent<Text>().text = "Press Spacebar to Snooze";
			textChanged = true;
		} else {
			timer += Time.deltaTime ;
		}
	}
}
