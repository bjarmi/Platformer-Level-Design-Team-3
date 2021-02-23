using System;
using AGDDPlatformer;
using UnityEngine;

public class NoDashZone : MonoBehaviour
{
    public string playerTag;

    private static void SetDashPermission(GameObject player, bool state)
    {
        PlayerController controller = player.GetComponent<PlayerController>();
        controller.dashAllowed = state;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
            SetDashPermission(other.gameObject, false);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
            SetDashPermission(other.gameObject, true);
    }
}