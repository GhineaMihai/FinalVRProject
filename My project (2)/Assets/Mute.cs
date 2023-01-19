using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public GameObject playerStanding;
    public bool interactable, sitting;
    public AudioSource source;
    public bool locked;
    // Start is called before the first frame update
    void Start()
    {
        source.mute = true;
        locked = true;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactable = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            locked = false;
        }
        if (locked == false)
        {
            if (interactable == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    sitting = true;
                    interactable = false;
                    if (playerStanding.transform.position.x < 12.0f)
                    {
                        source.mute = false;
                    }
                }
            }
            if (sitting == true)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    sitting = false;
                    if (playerStanding.transform.position.x < 12.0f)
                    {
                        source.mute = true;
                    }
                }
            }
        }
    }
}
