using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{

    public float speed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec * this.speed * Time.deltaTime);

        this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, -2.4f, 2.4f), this.transform.position.y, this.transform.position.z);



    }
}
