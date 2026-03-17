using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    // назва об'єкта, до якого буде рухатися агент
    [SerializeField] string targetName = "EnemyTarget";
    // максимальний рівень здоров'я агента
    [SerializeField] float maxHp = 20f;

    // Посилання на NavMeshAgent для керування рухом агента
    private NavMeshAgent agent;
    // Поточний рівень здоров'я агента
    private float currentHp;

    private void Start()
    {
        // Ініціалізація поточного здоров'я агента
        currentHp = maxHp;
        // Отримання компонента NavMeshAgent
        agent = GetComponent<NavMeshAgent>();
        // Встановлення цілі для руху агента
        agent.SetDestination(GameObject.Find(
            targetName).transform.position);
    }
}
