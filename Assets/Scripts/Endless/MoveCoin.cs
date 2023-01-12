using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCoin : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnCof;
    [SerializeField] private float turnSpeed;

    private void Start()
    {
        speed = 20f;
        turnSpeed = 10f;
    }

    private void FixedUpdate()
    {
        turnCof++;
        transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, turnCof *  turnSpeed, 0);
    }
}
