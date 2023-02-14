using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{

    Rigidbody2D rg2d;
    public float speed;

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
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rg2d.AddForce(movement*speed);
    }

}
