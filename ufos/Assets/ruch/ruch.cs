using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{

    Rigidbody2D rg2d;

    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>(); 
    }


    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveVertical, moveHorizontal);
        rg2d.AddForce(movement);
    }

}
