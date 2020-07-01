using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonKontrol : MonoBehaviour
{

    public Button playStopButton;
    public Sprite playImage;
    public Sprite stopImage;

    int i = 0;

    void Start()
    {
        
       
    }

    
    void Update()
    {
        
    }

    

    public void oyunuDurdurDevamEttir()
    {
        if(i % 2 == 0)
        {
            oyunKontrol.instantiate.stop = true;
            playStopButton.GetComponent<Image>().sprite = playImage;
            i++;
        }
        else
        {
            Invoke("oyunuDevamEttir", 0.5f);
            playStopButton.GetComponent<Image>().sprite = stopImage;
            i++;
        }
        
    }

    public void oyunuDevamEttir()
    {
        oyunKontrol.instantiate.stop = false ;
    }
}
