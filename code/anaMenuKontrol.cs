using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anaMenuKontrol : MonoBehaviour
{

    

    
    public GameObject settingsPanel;
    public Text levelCountText;
    public Text coinCountText;

    public Button soundButton;
    public Sprite soundOnImage;
    public Sprite soundOffImage;
    

    int j = 0;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        levelCountText.text = "" + PlayerPrefs.GetInt("kayit", 1);
        //coinCountText.text = "" + oyunKontrol.instantiate.i;
    }

    
    void Update()
    {
        
    }

    public void sesiAcKapa()
    {
        if (j % 2 == 0)
        {
            
            soundButton.GetComponent<Image>().sprite = soundOffImage;
            j++;
        }
        else
        {

            soundButton.GetComponent<Image>().sprite = soundOnImage;
            j++;
        }
    }

    public void settingsAcma()
    {
        settingsPanel.SetActive(true);
    }

    public void settingsKapama()
    {
        settingsPanel.SetActive(false);
    }
}
