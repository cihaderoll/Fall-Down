using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyonKontrol : MonoBehaviour
{
    public Animator coinAnimator;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(oyunKontrol.instantiate.stop == true ||
            oyunKontrol.instantiate.stopByEnd  == true)
        {
            coinAnimator.enabled = false;
            
        }
        else
        {
            coinAnimator.enabled = true ;
            
        }
    }
}
