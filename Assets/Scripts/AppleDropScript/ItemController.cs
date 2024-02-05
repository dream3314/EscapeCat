using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    void Update()
    {
        this.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        if(this.transform.position.y <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Catch!");
        Destroy(other.gameObject);
    }
}
