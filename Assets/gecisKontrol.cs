using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gecisKontrol : MonoBehaviour
{
    int level;

    public InterstitialAd interstitial;

    void Start()
    {
        #if UNITY_ANDROID
                string appId = "ca-app-pub-3233284452387623~9132799199";
        #elif UNITY_IPHONE
                                        string appId = "ca-app-pub-3940256099942544/4411468910";
        #else
                                        string appId = "unexpected_platform";
        #endif

                MobileAds.Initialize(appId);

        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-3940256099942544/1033173712";
        #elif UNITY_IPHONE
                                string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
                                string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        AdRequest request = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator).
            AddTestDevice("2077ef9a63d2b398840261c8221a0c9b").Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    
    void Update()
    {
        if(oyunKontrol.instantiate.gameOver == true)
        {
            if (this.interstitial.IsLoaded())
            {
                this.interstitial.Show();
            }
        }
        
    }

    public void MainPlayButton()
    {
        for(int i=1; i<8; i++)
        {
            if(PlayerPrefs.GetInt("kayit", 1) == i)
            {
                SceneManager.LoadScene("level" + i);
            }
        }
    }

    public void levelGecis()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    
    }

    public void level1()
    {
        SceneManager.LoadScene("level1");
    }

    public void level2()
    {
        if (PlayerPrefs.GetInt("kayit") >= 2)
        {
            SceneManager.LoadScene("level2");
        }
       
    }

    public void level3()
    {
        if (PlayerPrefs.GetInt("kayit") >= 3)
        {
            SceneManager.LoadScene("level3");
        }
    }

    public void level4()
    {
        if (PlayerPrefs.GetInt("kayit") >= 4)
        {
            SceneManager.LoadScene("level4");
        }

    }
    public void level5()
    {
        if (PlayerPrefs.GetInt("kayit") >= 5)
        {
            SceneManager.LoadScene("level5");
        }

    }
    public void level6()
    {
        if (PlayerPrefs.GetInt("kayit") >= 6)
        {
            SceneManager.LoadScene("level6");
        }

    }
    public void level7()
    {
        if (PlayerPrefs.GetInt("kayit") >= 7)
        {
            SceneManager.LoadScene("level7");
        }

    }
    public void level8()
    {
        if (PlayerPrefs.GetInt("kayit") >= 8)
        {
            SceneManager.LoadScene("level8");
        }

    }
    public void level9()
    {
        if (PlayerPrefs.GetInt("kayit") >= 9)
        {
            SceneManager.LoadScene("level9");
        }

    }
    public void level10()
    {
        if (PlayerPrefs.GetInt("kayit") >= 10)
        {
            SceneManager.LoadScene("level10");
        }

    }
    public void level11()
    {
        if (PlayerPrefs.GetInt("kayit") >= 11)
        {
            SceneManager.LoadScene("level11");
        }

    }
    public void level12()
    {
        if (PlayerPrefs.GetInt("kayit") >= 12)
        {
            SceneManager.LoadScene("level12");
        }

    }
    public void level13()
    {
        if (PlayerPrefs.GetInt("kayit") >= 13)
        {
            SceneManager.LoadScene("level13");
        }

    }
    public void level14()
    {
        if (PlayerPrefs.GetInt("kayit") >= 14)
        {
            SceneManager.LoadScene("level14");
        }

    }
    public void level15()
    {
        if (PlayerPrefs.GetInt("kayit") >= 15)
        {
            SceneManager.LoadScene("level15");
        }

    }
    public void level16()
    {
        if (PlayerPrefs.GetInt("kayit") >= 16)
        {
            SceneManager.LoadScene("level16");
        }

    }

    




    public void goHome()
    {
        SceneManager.LoadScene("anaMenu");
    }

    public void restart()
    {
        PlayerPrefs.SetInt("coinKayit", PlayerPrefs.GetInt("coinKayit") - oyunKontrol.instantiate.i);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void levelMenusu()
    {
        SceneManager.LoadScene("levelMenuScene");
    }

    public void menuPanelKapama()
    {
        oyunKontrol.instantiate.menuPanel.SetActive(false);
    }

    public void menuButton()
    {
        if(oyunKontrol.instantiate.stop == true)
        {
            oyunKontrol.instantiate.menuPanel.SetActive(true);
        }
        
    }

    public void cıkısEkranı()
    {
        oyunKontrol.instantiate.cikisPanel.SetActive(true);
    }

    public void cikisEkranıGeri()
    {
        oyunKontrol.instantiate.cikisPanel.SetActive(false);
    }

    public void oyundanCik()
    {
        Application.Quit();
    }



}
