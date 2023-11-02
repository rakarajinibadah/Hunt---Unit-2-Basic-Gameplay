using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
   

    //Destroys the gameObject that collided with our gameObject
    void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        Destroy(gameObject);

        UINilai.instance.AddPoint(Random.Range(5, 15));
    }
}
