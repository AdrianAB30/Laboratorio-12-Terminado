using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speedX = 10;
    public float speedY = 10;
    private Rigidbody2D rbd;
    private void Awake()
    {
        rbd = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        rbd.velocity = new Vector2(speedX * horizontal, speedY * vertical); 
    }
}
