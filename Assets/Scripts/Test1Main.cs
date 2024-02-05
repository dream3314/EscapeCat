using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1Main : MonoBehaviour
{

    [SerializeField] private Transform cubeTransform;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //�ȼ� ��ǥ�� ������ ����ȿ��� ���� ��ü�� �����.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //���� ��ü�� �������ִ� �Ӽ�
            //ray.origin : ������ġ
            //ray.direction : ����
                          //������ġ       ����            ����     ���ʵ���ǥ��?
            Debug.DrawRay(ray.origin, ray.direction * 20f, Color.red, 10);

            //���̿� �ݶ��̴� �浹 üũ

            RaycastHit hit; //�浹 �ߴٸ� �浹 ������ ��� ����(�浹 ������ ���)

            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                //���̿� �ݶ��̴��� �浹 �ߴ�
                Debug.Log("�浹��");
                Debug.Log($"=> {hit.point}");  //�浹 ������ġ(������ġ)
                this.cubeTransform.position = hit.point;
            }


            //========================================================

            //1.RaycastHit �������� ����
            //RaycastHit hit;

            //2.Physics.Raycase(������ġ, ����, out hit, length)
            //���̿� �ݶ��̴� �浹�� true�� ��ȯ �׷��� ������� fals�� ��ȯ

            //3.���ù� if(condition)

            //4.���࿡ �浹 �ߴٸ� ���ù� ����{}
            //if(condition)
            //{
            //   ���̿� �ݶ��̴��� �浹��
            //   �浹 ������ ����Ʈ ������ ��ġ�� �˼��ִ�.
            //   ������ ������ �������� hit ����ִ�.
            //}

            //RaycastGit git;

            //if(Physics.Raycase(out hit))
            //{
            // 
            //}
        }


    }
}
