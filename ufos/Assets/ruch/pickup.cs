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
       //odwo�a� si� do komponentu transform. Wywoa� metod� rotate. Utworzy� w niej nowy wektor - new vector3(0,0,45)*Time.deltaTime 
    }
}
