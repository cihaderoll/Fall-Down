using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HareketKarakter : MonoBehaviour
{
    Rigidbody2D fizik;
    


    void Start()
    {
        
        fizik = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        if (!(oyunKontrol.instantiate.stop) && !(oyunKontrol.instantiate.stopByEnd))
        {

        
            if (Input.GetMouseButton(0) && Input.mousePosition.x >= 550 && Input.mousePosition.y<= 1620)
            {
                
                if(fizik.velocity.x < 0)
                {
                    fizik.velocity = Vector2.zero;
                }
            
                fizik.AddForce(new Vector2(10, 0));

            }
            else if (Input.GetMouseButton(0) && Input.mousePosition.x < 550 && Input.mousePosition.y <= 1620)
            {
                if (fizik.velocity.x > 0)
                {
                    fizik.velocity = Vector2.zero;
                }
                fizik.AddForce(new Vector2(-10, 0));

            }
            else
            {
                if (fizik.velocity.x > 0)
                {


                    fizik.AddForce(new Vector2(-10, 0));
                    if(fizik.velocity.x < 0.2)
                    {
                        fizik.velocity = Vector2.zero;
                    }

                }
                else if(fizik.velocity.x < 0)
                {
                    fizik.AddForce(new Vector2(10, 0));
                    if (fizik.velocity.x > -0.2)
                    {
                        fizik.velocity = Vector2.zero;
                    }
                }

            }


        }
        else
        {
            fizik.velocity = Vector2.zero;
        }

        

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            //PlayerPrefs.SetInt("coinKayit", PlayerPrefs.GetInt("coinKayit") + 1);
            oyunKontrol.instantiate.i++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "bolumSonu")
        {
            //------------------------------------------------------------------------- COİN KAYIT OLUŞTURMA
            //if(oyunKontrol.instantiate.levelCount == 1)
            //{
            //    int i = 0;
            //    if(PlayerPrefs.GetInt("level", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level1", 0));
            //        PlayerPrefs.SetInt("level1"+i, oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level1", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 2)
            //{
            //    if (PlayerPrefs.GetInt("level2", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level2", 0));
            //        PlayerPrefs.SetInt("level2", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level2", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 3)
            //{
            //    if (PlayerPrefs.GetInt("level3", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level3", 0));
            //        PlayerPrefs.SetInt("level3", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level3", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 4)
            //{
            //    if (PlayerPrefs.GetInt("level4", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level4", 0));
            //        PlayerPrefs.SetInt("level4", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level4", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 5)
            //{
            //    if (PlayerPrefs.GetInt("level5", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level5", 0));
            //        PlayerPrefs.SetInt("level5", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level5", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 6)
            //{
            //    if (PlayerPrefs.GetInt("level6", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level6", 0));
            //        PlayerPrefs.SetInt("level6", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level6", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 7)
            //{
            //    if (PlayerPrefs.GetInt("level7", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level7", 0));
            //        PlayerPrefs.SetInt("level7", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level7", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 8)
            //{
            //    if (PlayerPrefs.GetInt("level8", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level8", 0));
            //        PlayerPrefs.SetInt("level8", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level8", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 9)
            //{
            //    if (PlayerPrefs.GetInt("level9", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level9", 0));
            //        PlayerPrefs.SetInt("level9", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level9", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 10)
            //{
            //    if (PlayerPrefs.GetInt("level10", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level10", 0));
            //        PlayerPrefs.SetInt("level10", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level10", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount ==11)
            //{
            //    if (PlayerPrefs.GetInt("level11", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level11", 0));
            //        PlayerPrefs.SetInt("level11", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level11", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 12)
            //{
            //    if (PlayerPrefs.GetInt("level12", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level12", 0));
            //        PlayerPrefs.SetInt("level12", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level12", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 13)
            //{
            //    if (PlayerPrefs.GetInt("level13", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level13", 0));
            //        PlayerPrefs.SetInt("level13", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level13", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 14)
            //{
            //    if (PlayerPrefs.GetInt("level14", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level14", 0));
            //        PlayerPrefs.SetInt("level4", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level14", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 15)
            //{
            //    if (PlayerPrefs.GetInt("level15", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level15", 0));
            //        PlayerPrefs.SetInt("level15", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level15", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 16)
            //{
            //    if (PlayerPrefs.GetInt("level16", 0) < oyunKontrol.instantiate.i)
            //    {
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level16", 0));
            //        PlayerPrefs.SetInt("level16", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level16", 0));
            //    }
            //}
            //else if (oyunKontrol.instantiate.levelCount == 4)
            //{
            //    if (PlayerPrefs.GetInt("level4", 0) < oyunKontrol.instantiate.i)
            //    {
            //        Debug.Log("level4");
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level4", 0));
            //        PlayerPrefs.SetInt("level4", oyunKontrol.instantiate.i);
            //        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level4", 0));
            //    }
            //}
            //-----------------------------------------------------------------------------------------LEVEL KAYIT OLUŞTURMA
            for(int i =0; i<9; i++)
            {
                if(i == SceneManager.GetActiveScene().buildIndex )
                {
                    if (PlayerPrefs.GetInt("level" + i, 0) < oyunKontrol.instantiate.i)
                    {
                        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) - PlayerPrefs.GetInt("level" + i, 0));
                        PlayerPrefs.SetInt("level" + i, oyunKontrol.instantiate.i);
                        PlayerPrefs.SetInt("toplamCoin", PlayerPrefs.GetInt("toplamCoin", 0) + PlayerPrefs.GetInt("level" + i, 0));
                    }
                }
            }
            


                oyunKontrol.instantiate.levelCount++;
            
            if(PlayerPrefs.GetInt("kayit", 1) <= oyunKontrol.instantiate.levelCount)
            {
                PlayerPrefs.SetInt("kayit", oyunKontrol.instantiate.levelCount);
            }
            oyunKontrol.instantiate.stopByEnd = true;
            oyunKontrol.instantiate.gameOver = true;
            

            Invoke("levelGeciss", 0.5f);
            
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "engel")
        {
            oyunKontrol.instantiate.stop = true;
            Invoke("gameOver", 0.5f);
        }
    }

    public void levelGeciss()
    {
        oyunKontrol.instantiate.levelGecisPanel.SetActive(true);
    }

    public void gameOver()
    {
        oyunKontrol.instantiate.gameOverPanel.SetActive(true);
    }

    
}
