using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformKontrol : MonoBehaviour
{
    
    private float targetPoint = 13;
    private int  speed = 2;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (!(oyunKontrol.instantiate.stop) && !(oyunKontrol.instantiate.stopByEnd))
        {
            movePlatform();
        }
        
    }

    private void movePlatform()
    {
        Vector2 _vector = transform.position;
        _vector.y = Mathf.MoveTowards(_vector.y, targetPoint, 0.03f * speed);
        if (Mathf.Abs(_vector.y - targetPoint) < 0.01f)
        {
            _vector.y = targetPoint;

        }
        transform.position = _vector;
    }
}
