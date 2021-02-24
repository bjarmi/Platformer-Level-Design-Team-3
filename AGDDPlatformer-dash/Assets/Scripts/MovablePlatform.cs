using System;
using System.Runtime.InteropServices;
using AGDDPlatformer;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class MovablePlatform : MonoBehaviour
{
    public GameObject player;
    public GameObject platform;
    public float speed;
    public Transform currentPoint;
    public Transform[] points;
    public int pointSelection;

    private void Start()
    {
        currentPoint = points[pointSelection];
    }

    private void FixedUpdate()
    {
        platform.transform.position = Vector3.MoveTowards(
            platform.transform.position,
            currentPoint.position,
            Time.deltaTime * speed
        );

        if (platform.transform.position != currentPoint.position) return;

        pointSelection++;

        if (pointSelection == points.Length)
            pointSelection = 0;

        currentPoint = points[pointSelection];
        
    }
}