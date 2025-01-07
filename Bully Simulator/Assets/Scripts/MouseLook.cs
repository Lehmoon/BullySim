using JetBrains.Annotations;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity; 

    public Transform playerBody;
    public Transform cameraBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);
        cameraBody.Rotate(Vector3.left * mouseY);


    }
}
