using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

     public float radius = 1f;

    void Update()
    {
        //키보드 입력을 받는 코드 작성
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 2유닛만큼 이동!!");
            //x축으로 -2만큼 이동
            this.transform.Translate(-2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로 2유닛만큼 이동!!");
            //x축으로 2만큼 이동
            this.transform.Translate(2, 0, 0);
        }
    }

    //이벤트 함수

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
