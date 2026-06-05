using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isOnGround;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }
}
