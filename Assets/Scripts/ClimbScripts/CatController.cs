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
            this.rbody.AddForce(Vector3.up * this.jumpForce); //월드상의 그린 엑시스(Y축)을 따라간다
        }
        //점프

        int dirX = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dirX = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            dirX = 1;
        }
        //방향
        //Debug.Log(dirX);  //방향 -1, 0, 1

        //스케일 X를 변경 하는데 키가 눌렸을 때만
        //키가 눌렸을때만 = (dirX != 0)
        if(dirX != 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }
        // 벡터의 곱   //벡터3
        // Debug.Log(this.transform.right * dirX);

        //속도 제한
        if ( Mathf.Abs(this.rbody.velocity.x) < 2.0)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveForce);
        }

        this.anim.speed = (Mathf.Abs(this.rbody.velocity.x) / 2f);
        this.gameDirector.UpdateVelocityText(this.rbody.velocity);
    }

    //Triger 모드일경우 충돌 판정을 해주는 이벤트 함수
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //최초로 충돌할때 한번만 호출
        //OntriggerExit2d = 나올때 한번만 호출
        //stay2d = 충돌중일때 계속 호출
        Debug.LogFormat("OnTriggerEnter2D: {0}", collision);

        //장면을 전환
        SceneManager.LoadScene("ClimbCloudClear");
    }
}
