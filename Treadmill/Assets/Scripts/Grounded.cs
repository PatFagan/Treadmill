using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Treadmill")
        {
            transform.parent.GetComponent<PlayerController>().grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Treadmill")
        {
            transform.parent.GetComponent<PlayerController>().grounded = false;
        }
    }
}