using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    bool wait;
    float timer;

	// Use this for initialization
	void Start () {
        wait = false;
        timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            wait = true;
        }

        if (wait == true)
        {
            timer += Time.deltaTime;
        }

        if (timer >= 30f)
        {
            GameObject.Find("Timer").GetComponent<Timer>().turnOnTimer();
            transform.Translate(0, 10 * Time.deltaTime, 0);
            if (timer >= 40f)
            {
                Destroy(this);
            }
        }
	}

    public float getTimer()
    {
        return timer;
    }
}
