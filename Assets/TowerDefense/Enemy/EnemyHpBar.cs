using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpBar : MonoBehaviour
{
    private AgentMove enemy;
    private Slider hpBar;
    private void Start()
    {
        enemy = GetComponentInParent<AgentMove>();
        hpBar = GetComponent<Slider>();
        
        hpBar.maxValue = enemy.maxHp;
        enemy.currentHp = enemy.maxHp;
    }
    private void FixedUpdate()
    {
        transform.LookAt(Camera.main.transform.position);
    }
    public void UpdateEnemyHpBar() 
    {
        hpBar.value = enemy.currentHp;
    }
}
