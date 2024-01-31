using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float moveForce = 1f;
    [SerializeField] private float jumpForce = 680f;

    [SerializeField] private ClimbCloudGameDirector gameDirector;

    private void Start()
    {
        
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
        Debug.Log(dirX);  //방향 -1, 0, 1

        //스케일 X를 변경 하는데 키가 눌렸을 때만
        //키가 눌렸을때만 = (dirX != 0)
        if(dirX != 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }       
        
        

        // 벡터의 곱   //벡터3
        Debug.Log(this.transform.right * dirX);

        //속도 제한
        if ( Mathf.Abs(this.rbody.velocity.x) < 2.0)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveForce);
        }
        
        this.gameDirector.UpdateVelocityText(this.rbody.velocity);
    }
}
