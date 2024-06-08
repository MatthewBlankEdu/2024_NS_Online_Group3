using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public float JumpForce;
    public Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody2D.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
