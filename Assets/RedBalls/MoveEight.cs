using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEight : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public float angle = 2f;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * angle * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Contact")) 
        {
            angle = angle * -1f;
        }
    }
}
