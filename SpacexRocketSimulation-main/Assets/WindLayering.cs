
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindLayering : MonoBehaviour
{
    [SerializeField]
    float windforce = 1000000f;
    public Vector3 windDirection;
    void OnTriggerStay(Collider other)
    {
        var hitObj = other.gameObject;
        if (hitObj != null)
        {
            var rb = hitObj.GetComponent<Rigidbody>();
            rb.AddForce(windDirection * windforce);
        }
    }


}