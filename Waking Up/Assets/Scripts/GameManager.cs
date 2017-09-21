using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	int count;
    float timer;

	// Use this for initialization
	void Start () {
		count = 0;
		DontDestroyOnLoad (gameObject);
        timer = 10;
	}

    void Update()
    {
        if (GameObject.Find("cover").GetComponent<Move>().getTimer() > 30)
        {
            timer -= Time.deltaTime;
                    if (timer <= 0)
                    {
                        GameObject.Find("InstructionsText").GetComponent<Text>().text = "";
                    }
        }
    }

    public void incrementCount()
	{
		count++;
	}

	public int getCount()
	{
		return count;
	}
}
