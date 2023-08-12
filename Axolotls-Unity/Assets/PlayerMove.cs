using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    bool jump = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     Rigidbody2D rb = GetComponent<Rigidbody2D>();
     if(Input.GetKey("right")){
        rb.AddForce(new Vector2(0.03f,0),ForceMode2D.Impulse);
     }else if(Input.GetKey("left")){
        rb.AddForce(new Vector2(-0.03f,0),ForceMode2D.Impulse);
     }

     if(Input.GetKey("up")){
        if(jump){
        rb.AddForce(new Vector2(0,5f),ForceMode2D.Impulse);
        jump = false;
        }
     }

    } 

    void OnCollisionEnter2D(Collision2D col){
        jump = true;
    }
}
