using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnKeyPress : AkTriggerBase
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
			if ((!GetComponent<ObjectManager>().wasActivated()) && Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position) <= 5)
            {
                if (triggerDelegate != null)
                {
					GameObject.Find ("GameManager").GetComponent<GameManager>().incrementCount();
					GetComponent<ObjectManager>().activate();
                    triggerDelegate(null);
                }
            }
        }
    }
}
