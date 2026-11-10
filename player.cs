using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class player : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(movementX,0.0f,movementY);
        rb.AddForce(movement);
    }
}
