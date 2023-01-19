using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    public GameObject object1, object2, main, crosshair1, popup;
    public bool interactable, interacted, popped;
    // Start is called before the first frame update
    void Start()
    {
        interacted = false;
        crosshair1.SetActive(false);
        main.SetActive(false);
        popup.SetActive(false);
        popped = false;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(object1.activeSelf == true)
            {
                crosshair1.SetActive(true);
                interactable = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            crosshair1.SetActive(false);
            interactable = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (interactable == true && object1.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                object1.SetActive(false);
                object2.SetActive(false);
                crosshair1.SetActive(false);
                main.SetActive(true);
                interacted = true;
                popup.SetActive(true);
                popped = true;
            }
        }
        if (popup.activeSelf == true && Input.GetKeyDown(KeyCode.Return))
        {
            popup.SetActive(false);
        }
    }
}
