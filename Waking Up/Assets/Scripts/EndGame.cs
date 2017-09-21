using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {
    string task;

	// Use this for initialization
	void Start () {
        task = GameObject.Find("GameManager").GetComponent<GameManager>().getCount() == 1 ? " task" : " tasks";
        if (SceneManager.GetActiveScene().name == "EndGame")
        {
            GameObject.Find("EndText").GetComponent<Text>().text = "On your way to work, you completed " + GameObject.Find("GameManager").GetComponent<GameManager>().getCount() + task + " out of a total of 7.";
        }
        else if (SceneManager.GetActiveScene().name == "LateEndGame")
        {
            GameObject.Find("EndText").GetComponent<Text>().text = "Ahh!! You spent too much time completing " + GameObject.Find("GameManager").GetComponent<GameManager>().getCount() + " tasks out of a total of 7 and you were late for work!";

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
