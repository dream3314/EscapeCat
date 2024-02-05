using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    [SerializeField] private AudioClip appleSfx;
    [SerializeField] private AudioClip bombSfx;

    private AudioSource audioSource;
    private GameObject director;

    private void Start()
    {
        this.director = GameObject.Find("AppleDirector");
        this.audioSource = this.GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray를 만든다
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //지역변수 RaycastHit hit정의 
            RaycastHit hit;

            // if문 작성  Physics.Raycast는 Ray랑 콜라이더가 충돌했을때 true를 반환 그렇지 않으면 false 반환
            if(Physics.Raycast(ray.origin, ray.direction, out hit, 20f))
            {
                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);
                this.transform.position = new Vector3(x,0 ,z);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        this.director.GetComponent<AppleDirector>().GetApple();
        this.director.GetComponent<AppleDirector>().GetBomb();
        Debug.LogFormat("Catch! = > {0}", other.gameObject.tag);
        
        
        if (other.CompareTag("Apple"))
        {
            Debug.Log("득점");
        }
        else if(other.CompareTag("Bomb"))
        {
            Debug.Log("감점");
        }
        Destroy(other.gameObject);
    }
}
