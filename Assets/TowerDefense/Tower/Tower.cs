using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Проджектайл")]
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] GameObject spawnPoint;
    [SerializeField] float attackInterval;

    [Header("Інше")]
    [HideInInspector] public List<GameObject> enemiesList;

    private void Start()
    {
        StartCoroutine(ProjectileSpawn());
    }

    private IEnumerator ProjectileSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(attackInterval);
            Instantiate(
                projectilePrefab,
                spawnPoint.transform.position,
                Quaternion.identity
                );
        }
    }
}
