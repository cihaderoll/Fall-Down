using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawAnimationController : MonoBehaviour
{
    public Animator sawAnimator;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (oyunKontrol.instantiate.stop == true ||
            oyunKontrol.instantiate.stopByEnd == true)
        {
            sawAnimator.enabled = false;

        }
        else
        {
            sawAnimator.enabled = true;

        }
    }
}
