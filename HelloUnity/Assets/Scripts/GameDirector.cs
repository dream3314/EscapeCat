using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private GameObject carGo;
    private GameObject flagGo;
    private GameObject distanceGo;
    private Text distanceText;
    
    void Start()
    {
        this.carGo = GameObject.Find("car");
        Debug.LogFormat("this.carGo: {0}", this.carGo);   //car ���ӿ�����Ʈ �ν��Ͻ�
        this.flagGo = GameObject.Find("flag");
        Debug.LogFormat("this.flagGo: {0}", this.flagGo);
        this.flagGo = GameObject.Find("distanceGo");
        Debug.LogFormat("this.distanceGo: {0}", this.distanceGo);

        Text distanceText = this.distanceGo.GetComponent<Text>();
        Debug.LogFormat("distanceText: {0}", distanceText);

        distanceText.text = "�ȳ��ϼ���";

    }

    
    void Update()
    {
        //�������Ӹ��� �ڵ����� ����� �Ÿ��� ���
        float length = this.flagGo.transform.position.x - this.carGo.transform.position.x;
        Debug.Log(length);
        distanceText.text = length.ToString();

    }
}
