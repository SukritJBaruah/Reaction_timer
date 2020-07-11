using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObject : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D coll)
    {
        // only blow up when colliding with a MouseObj
        if (coll.gameObject.tag == "MouseObj")
        {
            Destroy(gameObject);
        }
    }
}
