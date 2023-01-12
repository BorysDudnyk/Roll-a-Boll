using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        speed = Random.Range(20f, 60f);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
