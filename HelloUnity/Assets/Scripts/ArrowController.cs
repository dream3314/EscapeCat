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
        //이름으로 게임오브젝트를 찾는다.
        this.playerGo = GameObject.Find("player");
        //타입으로 찾는다(컴포넌트를 찾는다)
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
    }

    void Update()
    {
        //방향 * 속도 * 시간
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);
        Debug.LogFormat("y : {0}", this.transform.position.y);

        // 현재 y 좌표가 2.93보다 작아졌을때 씬에서 제거한다
        if (this.transform.position.y <= -3.17f)
        {
            Destroy(this.gameObject);   //씬에서 게임오브젝트(화살)를 제거한다.
        }

        // 거리
        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 - p2; // 방향
        float distance = dir.magnitude;  //거리

        float r1 = this.radius;
        float r2 = this.playerGo.GetComponent<PlayerController>().radius;
        float sumRadius = r1 + r2;

        if(distance < sumRadius)  //충돌함(겹침)
        {
            Debug.LogFormat("충돌함 : {0}, {1}", distance, sumRadius);
            Destroy(this.gameObject );  //씬에서 제거

            this.gameDirector.DecreaseHP();
        }

    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
