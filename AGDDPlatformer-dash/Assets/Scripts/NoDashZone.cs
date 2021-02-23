using AGDDPlatformer;
using UnityEngine;

public class NoDashZone : MonoBehaviour
{
    public string playerTag;

    private static void SetDashPermission(GameObject player, bool state)
    {
        PlayerController controller = player.GetComponent<PlayerController>();
        controller.canDash = state;
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag(playerTag))
            SetDashPermission(player.gameObject, false);
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag(playerTag))
            SetDashPermission(player.gameObject, true);
    }
}