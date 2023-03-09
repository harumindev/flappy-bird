using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    private void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Kiem tra phim Space co duoc bam khong?
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BirdMoveUp();
        }
    }
    private void BirdMoveUp() //lam chim bay len mot khoang
    {
        rb.velocity = Vector2.up * jumpForce;
    }
}