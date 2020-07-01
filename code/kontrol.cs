using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour
{

    private float targetPoint = 13f;
    private float speed = 2f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (!(oyunKontrol.instantiate.stop) && !(oyunKontrol.instantiate.stopByEnd))
        {
            MoveToWardsCloud();
        }
        
        
    }



    private void MoveToWardsCloud()
    {
        
            Vector2 _vector = transform.position;
            _vector.y = Mathf.MoveTowards(_vector.y, targetPoint, 0.03f * speed);
            if (Mathf.Abs(_vector.y - targetPoint) < 0.01f)
            {
                _vector.y = targetPoint;

            }
            transform.position = _vector;
            if (transform.position.y == 13)
            {
                transform.position = new Vector3(transform.position.x, -16f, transform.position.z);
            }
        
        
    }


}
