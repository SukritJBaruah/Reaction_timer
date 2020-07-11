using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MouseObj : MonoBehaviour
{
    float timeelapsed = 0;

    // Update is called once per frame
    void Update()
    {
        //destroys mouse object automatically after 0.2 seconds
        timeelapsed += Time.deltaTime;
        if(timeelapsed>=0.2)
        {
            Destroy(gameObject);
        }

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        // only blow up when colliding with a HitObject
        if (coll.gameObject.tag == "HitObject")
        {
            Destroy(gameObject);
        }
    }
}
