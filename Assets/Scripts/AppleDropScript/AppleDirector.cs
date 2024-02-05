using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleDirector : MonoBehaviour
{

    GameObject timerText;
    GameObject pointText;  
    float time = 60.0f;
    int point = 0;

    public void GetApple()
    {
        this.point += 50;
    }
    public void GetBomb()
    {
        this.point /= 2;
    }

    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point"); 
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime�� time���� ���� ī��Ʈ�ٿ� ����
        this.time -= Time.deltaTime;
        // �ð��� ���ڿ��� ��ȯ�ϰ� timerText UI�� ������Ʈ
        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text = this.point.ToString() + "Point";
    }
}
