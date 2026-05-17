using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    [Header("Налаштування керування")]
    [SerializeField] private float cameraSens = 1f; // Чутливість руху камери
    [SerializeField] private float zoomSens = 10f; // Чутливість зуму камери

    [Header("Обмеження обзору")]
    [SerializeField] private float minZoomDistance = 5f; // Мінімальна відстань зуму
    [SerializeField] private float maxZoomDistance = 30f; // Максимальна відстань зуму

    [Header("Обмеження руху камери")]
    [SerializeField] private float horizontalBorder = 50f; // Горизонтальна межа руху камери
    [SerializeField] private float verticalBorder = 50f; // Вертикальна межа руху камери

    private Vector3 initialPosition; // Початкова позиція камери
    private Vector3 positionLimits; // Межі руху камери

    private void Start()
    {
        // Зберігаємо початкову позицію камери
        initialPosition = transform.position;
        // Встановлюємо межі руху камери
        positionLimits = new Vector3(
            horizontalBorder,
            transform.position.y,
            verticalBorder);
    }
    private void Update()
    {
        CameraMove(); // Викликаємо метод для руху камери
        CameraZoom(); // Викликаємо метод для зуму камери
    }
    private void CameraMove()
    {
        // Отримуємо вхідні дані для руху камери
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // Рухаємо камеру відповідно до вхідних даних та чутливості
        transform.position = new Vector3(// Рухаємо камеру по горизонталі та вперед/назад
            transform.position.x + horizontal * cameraSens * Time.deltaTime,
            transform.position.y,
            transform.position.z + vertical * cameraSens * Time.deltaTime);

        // Обмежуємо рух камери в межах визначених горизонтальних та вертикальних кордонів
        transform.position = new Vector3(

            Mathf.Clamp( // Обмежуємо рух камери по горизонталі
                transform.position.x,// Поточна позиція камери по горизонталі
                initialPosition.x - positionLimits.x,// Мінімальна межа руху камери по горизонталі
                initialPosition.x + positionLimits.x),// Максимальна межа руху камери по горизонталі

            transform.position.y,// Поточна позиція камери по вертикалі (не змінюється)

            Mathf.Clamp( // Обмежуємо рух камери по вертикалі
                transform.position.z,// Поточна позиція камери по вертикалі
                initialPosition.z - positionLimits.z,// Мінімальна межа руху камери по вертикалі
                initialPosition.z + positionLimits.z));// Максимальна межа руху камери по вертикалі
    }
    public void CameraZoom()
    {
        // Отримуємо вхідні дані для зуму камери
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        // Змінюємо поле зору камери відповідно до вхідних даних та чутливості
        Camera.main.fieldOfView -= scroll * cameraSens * 100f * Time.deltaTime;
    }
}