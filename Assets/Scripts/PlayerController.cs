using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float speed;

   void Update () {

    float h = Input.GetAxisRaw("Horizontal");
    float v = Input.GetAxisRaw("Vertical");
   
    gameObject.transform.position = new Vector2 (transform.position.x + (h * speed), 
    transform.position.y + (v * speed));
    }
}