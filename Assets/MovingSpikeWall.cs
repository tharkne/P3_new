using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikeWall : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public SpikeWallStart controller;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (controller.startWall)
            rb.velocity = new Vector2(speed, 0);
        else
            rb.velocity = Vector2.zero;
    }
}
