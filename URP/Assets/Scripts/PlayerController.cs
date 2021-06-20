using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void OnMove(InputValue movement)
    {
        var v = movement.Get<Vector2>();
        movementX = v.x;
        movementY = v.y;
    }

    void FixedUpdate()
    {
        var v = new Vector3(movementX, 0, movementY);
        rb.AddForce(v * speed);
    }
}
