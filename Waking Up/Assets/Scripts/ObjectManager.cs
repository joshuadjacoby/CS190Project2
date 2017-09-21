using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour {
	private bool activated;

	// Use this for initialization
	void Start () {
		activated = false;
	}
	
	public bool wasActivated()
	{
		return activated;
	}

	public void activate()
	{
		activated = true;
	}
}
