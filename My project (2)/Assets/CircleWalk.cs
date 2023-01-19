using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleWalk : MonoBehaviour
{
    float speed = 1;
    float turn = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0f, turn * Time.deltaTime, 0f); 
        transform.position -= transform.forward * Time.deltaTime * speed;
    }
}
