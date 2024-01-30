using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    //1. 마우스 왼쪽 클릭을 하면
    //2. 회전한다

    void Start()
    {
       
    }
    [SerializeField]
    private float maxSpeed = 5;
    [SerializeField]
    private float attenuation = 0.96f;

    private float speed = 0;
 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Button Down!");
            speed = maxSpeed;
        }

        this.gameObject.transform.Rotate(0, 0, speed);
        speed *= attenuation;
    }
}
