using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CatEscapeGameDirector gameDirector;
    [SerializeField] private Button btnLeft;
    [SerializeField] private Button btnRight;

     public float radius = 1f;

    public int maxHp = 13;
    public int hp;

    private void Start()
    {
        this.btnLeft.onClick.AddListener(() => {Debug.Log("���� ȭ��ǥ ��ư Ŭ��");});
        this.transform.Translate(-2, 0, 0);
        this.btnRight.onClick.AddListener(() => {Debug.Log("������ ȭ��ǥ ��ư Ŭ��");});
        this.transform.Translate(2, 0, 0);
    }

    private void Awake()
    {
        this.hp = this.maxHp;
        Debug.LogFormat("<color=yellow>{0}/{1}</color>", this.hp, this.maxHp);
    }

    void Update()
    {
        //Ű���� �Է��� �޴� �ڵ� �ۼ�
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("�������� 2���ָ�ŭ �̵�!!");
            //x������ -2��ŭ �̵�
            this.transform.Translate(-2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("���������� 2���ָ�ŭ �̵�!!");
            //x������ 2��ŭ �̵�
            this.transform.Translate(2, 0, 0);
        }
    }

    //�̺�Ʈ �Լ�

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }

    public void LeftButtonClick()
    {
        Debug.Log("Left Button Clicked��");
    }

    public void RightButtonClick()
    {
        Debug.Log("Left Button licked��");
    }
}
