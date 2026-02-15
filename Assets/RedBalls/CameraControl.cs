using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y + 5f,
            transform.position.z - 10f);
    }
}
