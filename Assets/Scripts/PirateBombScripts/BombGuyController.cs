using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGuyController : MonoBehaviour
{
    [SerializeField] Transform flagTransform;

    //BombGuyController�� Animator������Ʈ�� �˾ƾ��Ѵ� 
    //��? �ִϸ��̼� ��ȯ�� �ؾ� �ϴϱ� 
    //Animator������Ʈ�� �ڽ� ������Ʈ anim�� �پ� �ִ� 
    //��� �ϸ� �ڽĿ�����Ʈ�� �پ� �ִ� Animator������Ʈ�� �����ü� ������?
    [SerializeField] private Animator anim;

    private Coroutine coroutine;

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("Enable");
    }

    private void Start()
    {
        Debug.Log("Start");
        //Transform animTransform = this.transform.Find("anim");
        //GameObject animGo = animTransform.gameObject;
        //this.anim = animGo.GetComponent<Animator>();
        //�ڷ�ƾ �Լ� ȣ��� 
        this.coroutine = this.StartCoroutine(this.CoMove(() => {
            Debug.LogFormat("�̵��� ��� �Ϸ� �߽��ϴ�.");
        }));
    }


    IEnumerator CoMove(System.Action callback)
    {
        //�� �����Ӹ��� ������ �̵� 
        while (true)
        {
            this.transform.Translate(transform.right * 1f * Time.deltaTime);
            float length = this.flagTransform.position.x - this.transform.position.x;
            Debug.LogFormat("�̵���.. �����Ÿ�  : {0}", length);
            if (length < 1)
            {
                break;  //while���� ����� 
            }
            yield return null;//�������������� �Ѿ��
        }

        Debug.Log("�̵��Ϸ�");
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        Debug.Log("End Of CoMove");
        callback();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //�ڷ�ƾ ���߱� 
            StopCoroutine(this.coroutine);
        }

        //if (Input.GetKeyDown(KeyCode.Alpha0))
        //{
        //    Debug.Log("Idle");
        //    //�ִϸ��̼� ��ȯ �ϱ� 
        //    //��ȯ �Ҷ� �Ķ���Ϳ� ���� �����ϱ� 
        //    this.anim.SetInteger("State", 0);
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    Debug.Log("Run");
        //    this.anim.SetInteger("State", 1);
        //}
    }
}