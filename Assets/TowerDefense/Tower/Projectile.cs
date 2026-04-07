using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject targetObj; // ціль кулі
    [SerializeField] private float projectileSpeed = 10f;

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetObj.transform.position,
            projectileSpeed * Time.fixedDeltaTime);

        transform.LookAt(targetObj.transform);
    }
}
