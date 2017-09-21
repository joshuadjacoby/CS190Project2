using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Exit")
		{
			SceneManager.LoadScene ("EndGame");
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(0,speed * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(-speed * Time.deltaTime, 0, 0);
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(0, -speed * Time.deltaTime, 0);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(speed * Time.deltaTime, 0, 0);
		}
	}
}
