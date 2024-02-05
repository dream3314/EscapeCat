using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneMain : MonoBehaviour
{
    [SerializeField] private Text textHp;
    [SerializeField] Button btnLoadScene;
    [SerializeField] private GameObject HeroPrefab;
    void Start()
    {
        //��ư�� Ŭ���ϸ� ���ٹ��� ȣ��� 
        this.btnLoadScene.onClick.AddListener(() => {
            Debug.Log("VillegeScene���� ��ȯ");
            SceneManager.LoadScene("VillageScene");
        });

        this.CreateHero();
    }

    private void CreateHero()
    {
        GameObject heroGo = Instantiate(this.HeroPrefab); 
        Debug.LogFormat("heroGo: {0}", heroGo);
        HeroController heroController = heroGo.GetComponent<HeroController>();

        heroController.onHit = () => {

            Debug.Log("������ ���ظ� �޾ҽ��ϴ�.");


        };

    }

}
