using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject apple;
    public GameObject bomb;
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span )
        {
            this.delta = 0;
            GameObject item = Instantiate(apple);
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 3, z);
        }
    }
}
