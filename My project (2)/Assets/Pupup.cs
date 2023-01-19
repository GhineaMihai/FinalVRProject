using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pupup : MonoBehaviour
{
    public GameObject popup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (popup.activeSelf == true && Input.GetKeyDown(KeyCode.Return))
        {
            popup.SetActive(false);
        }
    }
}
