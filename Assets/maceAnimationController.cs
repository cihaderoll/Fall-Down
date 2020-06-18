using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maceAnimationController : MonoBehaviour
{
    public Animator maceAnimator;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (oyunKontrol.instantiate.stop == true ||
            oyunKontrol.instantiate.stopByEnd == true)
        {
            maceAnimator.enabled = false;

        }
        else
        {
            maceAnimator.enabled = true;

        }
    }
}
