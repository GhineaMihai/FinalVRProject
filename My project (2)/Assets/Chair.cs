using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public GameObject playerStanding, playerSitting, intText, standText, prompt;
    public bool interactable, sitting;
    public int count = 0;
    public bool popped;
    void Start()
    {
        intText.SetActive(false);
        standText.SetActive(false);
        prompt.SetActive(false);
        popped= false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (prompt.activeSelf== false)
        {
            if (interactable == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    intText.SetActive(false);
                    playerSitting.SetActive(true);
                    sitting = true;
                    playerStanding.SetActive(false);
                    interactable = false;
                    if (popped == false)
                    {
                        popped = true;
                        prompt.SetActive(true);
                    }
                    if (count > 0)
                        standText.SetActive(true);
                }
            }
            if (sitting == true)
            {
                if (prompt.activeSelf == false)
                {
                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        count++;
                        standText.SetActive(true);
                    }
                    if (count > 0 && Input.GetKeyDown(KeyCode.Q))
                    {
                        playerSitting.SetActive(false);
                        standText.SetActive(false);
                        playerStanding.SetActive(true);
                        sitting = false;
                    }
                }
            }
        }
        if (prompt.activeSelf == true && Input.GetKeyDown(KeyCode.Return))
        {
            prompt.SetActive(false);
        }
    }
}