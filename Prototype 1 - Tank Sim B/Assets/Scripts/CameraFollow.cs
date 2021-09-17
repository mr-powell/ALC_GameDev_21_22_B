using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject tank;

    private Vector3 offset = new Vector3(0,25,-50);
    

    // Update is called once per frame
    void Update()
    {
        //The cameras position copies the tanks with an offset
        transform.position = tank.transform.position + offset;
    }
}
