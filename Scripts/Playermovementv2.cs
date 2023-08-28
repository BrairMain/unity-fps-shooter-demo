using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovementv2 : MonoBehaviour
{
   public float speed = 10f;
   public Rigidbody rb;
   public bool cubeIsOnTheGround = true;
   

   private void Start ()
   {
    rb = GetComponent<Rigidbody>();
   }
   
   void Update ()
   {
    float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
    float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

    transform.Translate(horizontal, 0,vertical);

    if(Input.GetButtonDown("Jump") && cubeIsOnTheGround)
    {
        rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        cubeIsOnTheGround = false;
    }

   }

   private void OnCollisionEnter(Collision collision)
   {
    if(collision.gameObject.tag == "Ground")
    {
        cubeIsOnTheGround =true;
    }
   }
}
