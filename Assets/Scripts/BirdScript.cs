using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject panel;
    public GameObject player;
    public GameObject pause;
    public float jump_power;
    public float skor;
    public Text skor_text;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jump_power;
        }

        skor_text.text= skor.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Scorer")
        {
            skor++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pipe")
        {
            panel.SetActive(true);
            player.SetActive(false);
            pause.SetActive(false);
            Time.timeScale = 0f;
        }
        
    }
}
