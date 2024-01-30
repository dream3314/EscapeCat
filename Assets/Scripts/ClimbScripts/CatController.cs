using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float force = 680f;
    [SerializeField] private float move = 10f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //this.rbody.AddForce(this.transform.up * this.force);
            this.rbody.AddForce(Vector3.up * this.force); //������� �׸� ���ý�(Y��)�� ���󰣴�
        }
        //����

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("�������� �̵�!!");
            this.transform.Translate(Vector3.left * this.move);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("���������� �̵�!!");
            this.transform.Translate(2, 0, 0);
        }
    }
}
