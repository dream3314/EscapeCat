using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] public float radius = 1f;
    [SerializeField] public float speed = 1f;

    public CatEscapeGameDirector gameDirector;

    private GameObject playerGo;

    private void Start()
    {
        //�̸����� ���ӿ�����Ʈ�� ã�´�.
        this.playerGo = GameObject.Find("player");
        //Ÿ������ ã�´�(������Ʈ�� ã�´�)
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
    }

    void Update()
    {
        //���� * �ӵ� * �ð�
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);
        Debug.LogFormat("y : {0}", this.transform.position.y);

        // ���� y ��ǥ�� 2.93���� �۾������� ������ �����Ѵ�
        if (this.transform.position.y <= -3.17f)
        {
            Destroy(this.gameObject);   //������ ���ӿ�����Ʈ(ȭ��)�� �����Ѵ�.
        }

        // �Ÿ�
        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 - p2; // ����
        float distance = dir.magnitude;  //�Ÿ�

        float r1 = this.radius;
        float r2 = this.playerGo.GetComponent<PlayerController>().radius;
        float sumRadius = r1 + r2;

        if(distance < sumRadius)  //�浹��(��ħ)
        {
            Debug.LogFormat("�浹�� : {0}, {1}", distance, sumRadius);
            Destroy(this.gameObject );  //������ ����

            this.gameDirector.DecreaseHP();
        }

    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
