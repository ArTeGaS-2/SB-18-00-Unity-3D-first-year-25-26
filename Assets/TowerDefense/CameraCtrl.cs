using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    [Header("Налаштування керування")]
    [SerializeField] private float cameraSens = 1f;
    [SerializeField] private float distanceToGround = 10f;

    [Header("Обмеження обзору")]
    [SerializeField] private float minDistance = 5f;
    [SerializeField] private float maxDistance = 30f;
    [SerializeField] private float horizontalBorder = 50f;
    [SerializeField] private float verticalBorder = 50f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = new Vector3(
            transform.position.x + horizontal * cameraSens * Time.deltaTime,
            transform.position.y,
            transform.position.z + vertical * cameraSens * Time.deltaTime);
    }
}
