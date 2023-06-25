using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D  myrigidbody;
    public float flyspeed;
    public LogicScript logic;
    private bool birdalive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdalive==true)
        {
            myrigidbody.velocity = Vector2.up * flyspeed;
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdalive = false;
    }
}
