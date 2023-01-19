using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    public float Sensitivity = 100f;
    public Transform playerBody;
    float xrotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        xrotation -= mouseY;

        transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
