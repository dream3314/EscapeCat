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
            //픽셀 좌표를 가지고 월드안에서 레이 객체를 만든다.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //레이 객체가 가지고있는 속성
            //ray.origin : 시작위치
            //ray.direction : 방향
                          //시작위치       방향            색상     몇초동안표시?
            Debug.DrawRay(ray.origin, ray.direction * 20f, Color.red, 10);

            //레이와 콜라이더 충돌 체크

            RaycastHit hit; //충돌 했다면 충돌 정보를 담는 변수(충돌 정보가 담김)

            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                //레이와 콜라이더가 충돌 했다
                Debug.Log("충돌함");
                Debug.Log($"=> {hit.point}");  //충돌 지점위치(월드위치)
                this.cubeTransform.position = hit.point;
            }


            //========================================================

            //1.RaycastHit 지역변수 선언
            //RaycastHit hit;

            //2.Physics.Raycase(시작위치, 방향, out hit, length)
            //레이와 콜라이더 충돌시 true를 반환 그렇지 않을경우 fals를 반환

            //3.선택문 if(condition)

            //4.만약에 충돌 했다면 선택문 본문{}
            //if(condition)
            //{
            //   레이와 콜라이더가 충돌함
            //   충돌 정보중 임팩트 지점의 위치를 알수있다.
            //   위에서 선언한 지역변수 hit 담겨있다.
            //}

            //RaycastGit git;

            //if(Physics.Raycase(out hit))
            //{
            // 
            //}
        }


    }
}
