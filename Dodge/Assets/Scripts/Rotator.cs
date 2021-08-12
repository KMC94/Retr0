using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSPeed = 60f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f, rotationSPeed * Time.deltaTime, 0f);
    }
}
