using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCars : MonoBehaviour
{
    private float speed = 20f; 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }
}
