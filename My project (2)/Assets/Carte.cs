using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Carte : MonoBehaviour
{
    public GameObject carte, popup, popupmain;
    public bool interactable, sitting, popped;
    // Start is called before the first frame update
    void Start()
    {
        carte.SetActive(false);
        popup.SetActive(false);
        popupmain.SetActive(false);
        popped = false;
    }
    void OnTriggerStay(Collider other)
    {
        if (popupmain.activeSelf == false)
        {
            if (other.CompareTag("PlayerCamera"))
            {
                interactable = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerCamera"))
        {
            interactable = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                carte.SetActive(true);
                sitting = true;
                interactable = false;
                Cursor.lockState = CursorLockMode.None;
            }
        }
        if (sitting == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                carte.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                if(popped == false)
                {
                    popped = true;
                    popup.SetActive(true);
                }
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                carte.SetActive(false);
                sitting = false;
                Cursor.lockState = CursorLockMode.Locked;
                popup.SetActive(false);
            }
            if (popup.activeSelf == true && Input.GetKeyDown(KeyCode.Return))
            {
                    popup.SetActive(false);
            }
        }
    }
}
