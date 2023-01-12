using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private Animator CameraAnim;
    [SerializeField] private float maxTime;

    private void Start()
    {
        CameraAnim = GetComponent<Animator>();
    }
    void Update()
    {
        if (maxTime > 20)
        {
            CameraAnim.SetBool("isRotate", true);
        }

        if (maxTime > 50)
        {
            CameraAnim.SetBool("isRotate", false);
            maxTime = 0;
        }

        maxTime += Time.deltaTime;
    }
}
