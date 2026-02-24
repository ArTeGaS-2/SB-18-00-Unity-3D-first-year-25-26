using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private GameObject cameraObj;
    private float mouseVectorX = 0f;
    private float mouseVectorY = 0f;

    [SerializeField] private bool staticCamera = false;
    private void FixedUpdate()
    {
        mouseVectorX = Input.GetAxis("Mouse X");
        mouseVectorY = Input.GetAxis("Mouse Y");

        if (!staticCamera) 
        {
            cameraObj.transform.Rotate(new Vector3(
            -mouseVectorY, mouseVectorX, 0f));

            Vector3 eulerAngles = cameraObj.transform.eulerAngles;
            eulerAngles.z = 0f;
            cameraObj.transform.eulerAngles = eulerAngles;
        }
    }
    private void LateUpdate()
    {
        cameraObj.transform.position = new Vector3(
            transform.position.x,
            transform.position.y + 5f,
            transform.position.z - 10f);
    }
}
