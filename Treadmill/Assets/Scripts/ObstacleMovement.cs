using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    bool onTreadmill;
    public float treadmillSpeed;

    void FixedUpdate()
    {
        if (onTreadmill)
        {
            transform.Translate(-1f * treadmillSpeed, 0f, 0f);
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Treadmill")
        {
            onTreadmill = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Treadmill")
        {
            onTreadmill = false;
        }
    }
}