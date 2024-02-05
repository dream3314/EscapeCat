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
        //버튼을 클릭하면 람다문이 호출됨 
        this.btnLoadScene.onClick.AddListener(() => {
            Debug.Log("VillegeScene으로 전환");
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

            Debug.Log("영웅이 피해를 받았습니다.");


        };

    }

}
