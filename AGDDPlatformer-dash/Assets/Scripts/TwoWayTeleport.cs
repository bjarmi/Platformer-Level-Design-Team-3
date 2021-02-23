using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoWayTeleport : MonoBehaviour
{
    public Vector2 destination;
    public GameObject Player;
    public float waitTime;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player1")
        {
            StartCoroutine (Teleport());
        } 
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(waitTime);
        Player.transform.position = destination;
    }
}

