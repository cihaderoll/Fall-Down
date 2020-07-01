using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunKontrol : MonoBehaviour
{
    public static oyunKontrol instantiate;

    
    public Text coinText;


    public GameObject levelText;
    public GameObject levelGecisPanel;
    public GameObject gameOverPanel;
    public GameObject menuPanel;
    public GameObject cikisPanel;


    public int levelCount;
    public int i = 0;

    public bool gameOver = false;
    public bool stop = false;
    public bool stopByEnd = false;

    private void Awake()
    {

        instantiate = this;
    }

    private void Start()
    {
        Invoke("BaslangıcBekleme", 1f);
        levelGecisPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        menuPanel.SetActive(false);


    }


    private void Update()
    {
        
        
        coinText.text = "" + PlayerPrefs.GetInt("toplamCoin", 0);
    }


    //public void levelGecis()
    //{
    //    SceneManager.LoadScene("levelGecisScene");
    //}

    public void gameOverScene()
    {
        SceneManager.LoadScene("gameOverScene");
    }

    public void BaslangıcBekleme()
    {
        stop = false ;
        stopByEnd = false;
        levelText.SetActive(false);
    }


}
