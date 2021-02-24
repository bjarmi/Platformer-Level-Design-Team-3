using AGDDPlatformer;
using UnityEngine;

public class NoDashZone : MonoBehaviour
{
    public GameObject player;
    private PlayerController _controller;

    private void Start()
    {
        _controller = player.GetComponent<PlayerController>();
    }

    private void SetDashPermission(bool state)
    {
        _controller.dashAllowed = state;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SetDashPermission(false);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        SetDashPermission(true);
    }
}