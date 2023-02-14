using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
       //odwo³aæ siê do komponentu transform. Wywoaæ metodê rotate. Utworzyæ w niej nowy wektor - new vector3(0,0,45)*Time.deltaTime 
    }
}
