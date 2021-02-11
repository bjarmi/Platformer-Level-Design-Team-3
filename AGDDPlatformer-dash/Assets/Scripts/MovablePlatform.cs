using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class MovablePlatform : MonoBehaviour
{
    public float speed;
    public Transform target;
    
    private Vector3 _initialPosition;
    private Vector3 _targetPosition;
    private bool _moveTowards = true; // true = target, false = _initialPosition


    private void Start()
    {
        _initialPosition = transform.position;
        _targetPosition = target.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 currentPosition = transform.position;
        if (_moveTowards)
        {
            transform.position = Vector3.MoveTowards(
                currentPosition,
                _targetPosition,
                speed);
            _moveTowards = !(currentPosition == _targetPosition);
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                currentPosition,
                _initialPosition,
                speed);
            _moveTowards = (currentPosition == _initialPosition);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            other.collider.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            other.collider.transform.SetParent(null);
        }
    }
}
