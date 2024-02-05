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
            //Ray�� �����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //�������� RaycastHit hit���� 
            RaycastHit hit;

            // if�� �ۼ�  Physics.Raycast�� Ray�� �ݶ��̴��� �浹������ true�� ��ȯ �׷��� ������ false ��ȯ
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
            Debug.Log("����");
        }
        else if(other.CompareTag("Bomb"))
        {
            Debug.Log("����");
        }
        Destroy(other.gameObject);
    }
}
