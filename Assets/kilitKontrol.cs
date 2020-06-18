using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kilitKontrol : MonoBehaviour
{
    public GameObject []kilitImages;
    void Start()
    {
        for(int i=0; i<PlayerPrefs.GetInt("kayit", 1); i++)
        {
            kilitImages[i].SetActive(false);
            
        }

    }

    
    void Update()
    {
        
    }
}
