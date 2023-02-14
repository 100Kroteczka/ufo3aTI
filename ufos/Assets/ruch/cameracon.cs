using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracon : MonoBehaviour
{ 
    public GameObject ufo;
    private Vector3 offset;
   void Start()
    {
        offset = transform.position - ufo.transform.position;        
    }
    void Update()
    {
        transform.position = ufo.transform.position + offset;
    }
}
