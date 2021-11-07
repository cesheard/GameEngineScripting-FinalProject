using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody = null;
    [SerializeField] private float speed = 1.0f;
    private Vector3 currentDirection = Vector3.zero;

    private void Awake()
    {
        currentDirection = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0).normalized;
    }

    private void FixedUpdate()
    {
        var newDelta = currentDirection * Time.deltaTime * speed;
        rigidBody.MovePosition(transform.position + newDelta);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Occured");
        currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);
    }
}
