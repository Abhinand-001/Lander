
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindLayering : MonoBehaviour
{
    [SerializeField]
    float windforce = 1000000f;
    private void OnTriggerStay(Collider other)
    {   
        var hitObj = other.gameObject;
        if (hitObj != null)
        {
            var rb = hitObj.GetComponent<Rigidbody>();
            var dir = transform.up;
            rb.AddForce(dir * windforce);
            //Debug.Log("Wind force applied");
        }
    }


}