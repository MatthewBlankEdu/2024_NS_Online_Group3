using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public float JumpForce;
    public Rigidbody2D rigidbody2D;

    public int Points;

    public static bool GameOver;
    public static bool HasStarted;

    public GameObject GameOverPanel;
    public TextMeshProUGUI PointTextField;
    
    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        HasStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        PointTextField.text = Points.ToString();
        
        if(GameOver) 
            return;
        
        if (Input.GetButtonDown("Jump"))
        {
            if (HasStarted == false)
            {
                HasStarted = true;
                rigidbody2D.gravityScale = 1;
            }
            
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Points++;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameOver = true;
        GameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
