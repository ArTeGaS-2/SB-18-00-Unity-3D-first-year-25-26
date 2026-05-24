using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Проджектайл")]
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] GameObject spawnPoint;
    [SerializeField] float attackInterval = 1f;
    [SerializeField] float attackDamage = 1f;
    [SerializeField] float attackRadius = 5f;
     
    [Header("Інше")] 
    [HideInInspector] public List<GameObject> enemiesList;

    private bool ifEnemyInRadius; // Індикатор того - чи є ворог у радіусі
    private Coroutine towerAttack; // Короутіна атаки вежі

    private void Awake()
    {
        enemiesList = new List<GameObject>();
    }

    private void Start()
    {
        // StartCoroutine(ProjectileSpawn());
        towerAttack = null;
    }

    private IEnumerator ProjectileSpawn()
    {
        while (true) 
        {
            if (enemiesList.Count > 0)
            {
                Projectile projectile = Instantiate(
                    projectilePrefab,
                    spawnPoint.transform.position,
                    Quaternion.identity
                    ).GetComponent<Projectile>();

                projectile.targetObj = enemiesList[0];
            }
            yield return new WaitForSeconds(attackInterval);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if(enemiesList.Count == 0)
            {
                towerAttack = StartCoroutine(ProjectileSpawn());
                enemiesList.Add(other.gameObject);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (enemiesList.Count == 0)
            {
                StopCoroutine(towerAttack);
                enemiesList.Remove(other.gameObject);
            }
        }
    }
}
