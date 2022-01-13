using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 0.1f;
    public Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Speed);
    }

     
}
