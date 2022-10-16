using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        body.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
    }
}
