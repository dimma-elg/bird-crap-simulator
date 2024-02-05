using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakkaPhysics : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "target")
        {
             
        }
    }
}
