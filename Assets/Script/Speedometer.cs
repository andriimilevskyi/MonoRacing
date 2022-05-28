using UnityEngine;
using System.Collections;

public class Speedometer : MonoBehaviour
{
    private float _start = 191; // начальное положение стрелки по оси Z
    private float _end = -7;
    private float maxSpeed = 160; // максимальная скорость на спидометре
    public RectTransform arrow; // стрелка спидометра
    public Transform target; // объект с которого береться скорость
    public float velocity; // текущая реальная скорость объекта
    private Rigidbody rb;
    private float speed;
    private float unit;
    
    void Start()
    {
        unit = (_start - _end) / maxSpeed;
        arrow.localRotation = Quaternion.Euler(0, 0, _start);
        rb = target.GetComponent<Rigidbody>();
    }

    void Update()
    {
        velocity = rb.velocity.magnitude;
        if (velocity > maxSpeed)
        {
            velocity = maxSpeed;
        }
        speed = _start - unit * velocity;
        arrow.localRotation = Quaternion.Euler(0, 0, speed);
    }
}