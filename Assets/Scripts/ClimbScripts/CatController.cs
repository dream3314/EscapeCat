using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float moveForce = 3f;
    [SerializeField] private float jumpForce = 680f;

    [SerializeField] private ClimbCloudGameDirector gameDirector;

    private Animator anim;

    private void Start()
    {
        //this.gameObject.GetComponent<Animator>();
        this.anim = GetComponent<Animator>();
        anim.speed = moveForce;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //this.rbody.AddForce(this.transform.up * this.force);
            this.rbody.AddForce(Vector3.up * this.jumpForce); //������� �׸� ���ý�(Y��)�� ���󰣴�
        }
        //����

        int dirX = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dirX = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            dirX = 1;
        }
        //����
        //Debug.Log(dirX);  //���� -1, 0, 1

        //������ X�� ���� �ϴµ� Ű�� ������ ����
        //Ű�� ���������� = (dirX != 0)
        if(dirX != 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }
        // ������ ��   //����3
        // Debug.Log(this.transform.right * dirX);

        //�ӵ� ����
        if ( Mathf.Abs(this.rbody.velocity.x) < 2.0)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveForce);
        }

        this.anim.speed = (Mathf.Abs(this.rbody.velocity.x) / 2f);
        this.gameDirector.UpdateVelocityText(this.rbody.velocity);
    }

    //Triger ����ϰ�� �浹 ������ ���ִ� �̺�Ʈ �Լ�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���ʷ� �浹�Ҷ� �ѹ��� ȣ��
        //OntriggerExit2d = ���ö� �ѹ��� ȣ��
        //stay2d = �浹���϶� ��� ȣ��
        Debug.LogFormat("OnTriggerEnter2D: {0}", collision);

        //����� ��ȯ
        SceneManager.LoadScene("ClimbCloudClear");
    }
}
