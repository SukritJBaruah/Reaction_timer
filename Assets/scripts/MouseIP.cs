using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseIP : MonoBehaviour
{

    [SerializeField]
    GameObject prefabMouseObj;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = -Camera.main.transform.position.z;
            pos = Camera.main.ScreenToWorldPoint(pos);
            Instantiate<GameObject>(prefabMouseObj, pos, Quaternion.identity);

        }
    }
}
