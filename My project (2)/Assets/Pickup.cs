using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject crosshair1;
    public GameObject object1, object2, main, popupmain;
    public bool interactable, pickedup, pickable;
    void Start()
    {
        object1.SetActive(false); 
        object2.SetActive(false);
        crosshair1.SetActive(false);
        pickable = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (popupmain.activeSelf == false && pickable == true)
            if (other.CompareTag("MainCamera"))
            {
                interactable = true;
                if (pickedup == false)
                {
                    crosshair1.SetActive(true);
                }
                if (pickedup == true)
                {
                    crosshair1.SetActive(false);
                }
            }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (pickedup == false)
            {
                crosshair1.SetActive(false);
                interactable = false;
            }
            if (pickedup == true)
            {
                crosshair1.SetActive(false);
                interactable = false;
                pickedup = false;
            }
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                object1.SetActive(true);
                object2.SetActive(true);
                crosshair1.SetActive(false);
                main.SetActive(false);
                pickedup = true;
            }
        }
    }
}