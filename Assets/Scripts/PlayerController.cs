using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float strength = 1;

    private Rigidbody2D rb;

    public AudioSource wingSound;
    public AudioSource hitSound;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(new Vector2(0, strength), ForceMode2D.Impulse);
            rb.velocity = Vector2.up * strength;
            wingSound.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        hitSound.Play();
        GameManager.Instance.OnGameOver();
    }
}
