using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starKontrol : MonoBehaviour
{
    public static starKontrol starkontrol;

    private void Awake()
    {
        starkontrol = this;
    }

    public GameObject []stars;
    void Start()
    {
        if(this.tag == "level1")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level1", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level2")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level2", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level3")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level3", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level4")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level4", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level5")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level5", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level6")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level6", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level7")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level7", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level8")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level8", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level9")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level9", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level10")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level10", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level11")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level11", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level12")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level12", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level13")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level13", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level14")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level14", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level15")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level15", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
        else if (this.tag == "level16")
        {
            for (int i = 0; i < PlayerPrefs.GetInt("level16", 0); i++)
            {
                stars[i].SetActive(true);
            }
        }
    }

    
    void Update()
    {
        
    }
}
