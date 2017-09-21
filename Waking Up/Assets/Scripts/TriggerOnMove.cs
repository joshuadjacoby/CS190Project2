using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnMove : AkTriggerBase
{

    public Rigidbody player;

    private void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        Debug.Log(player.velocity.x);
        Debug.Log(player.velocity.y);
        if (player.velocity.x > 0f || player.velocity.y > 0f)
        {
            if (triggerDelegate != null)
            {
                triggerDelegate(null);
            }
        }

    }
}
