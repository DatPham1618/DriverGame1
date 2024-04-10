using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float rotatespeed = 1f;
    [SerializeField]float  movespeed = 0.41f;
    [SerializeField]float slowspeed = 15f;

    [SerializeField]float boostspeed = 30f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
      
        float rotateInput = Input.GetAxis("Horizontal") * rotatespeed * Time.deltaTime;
        float moveInput = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotateInput);
        transform.Translate(0, moveInput, 0);                
    }
    void OnCollisionEnter2D(Collision2D other) {
            movespeed = slowspeed;    
        }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost"){

            movespeed = boostspeed;

            }    
        }
}
