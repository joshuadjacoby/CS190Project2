using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AlarmStop : AkTriggerBase
{
    bool activated;

    private void Start()
    {
        activated = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !activated)
        {
            if (triggerDelegate != null)
            {
                triggerDelegate(null);
            }
			GameObject.Find ("SpacebarText").GetComponent<Text> ().text = "";
			GameObject.Find ("InstructionsText").GetComponent<Text> ().text = "Hurry up and get to work!! Press 'E' to interact with objects while you get ready.";

            activated = true;
        }
    }
}
