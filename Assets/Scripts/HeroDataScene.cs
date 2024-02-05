using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDataScene : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
