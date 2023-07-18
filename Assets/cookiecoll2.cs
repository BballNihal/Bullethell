using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiecoll2 : MonoBehaviour
{
    public int hp;
    private int rhp;
    public GameObject cookie4;
    public GameObject cookie5;
    public GameObject cookie6;
    public GameObject bruhcookie2;
    public static int dcookie2;
    // Start is called before the first frame update
    void Start()
    {
        rhp = hp;
        dcookie2 = 0;
        print (dcookie2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.gameObject.GetComponent<gbullet>() != null)
        {
          Destroy(collision.gameObject);
          rhp = hp--;
          if (rhp == 0)
            {
            cookiecoll3.dcookie3 += 1;
            if (dcookie2 == 1)
              {
                Instantiate(cookie4, new Vector3(0,0,0), transform.rotation);
                Instantiate(cookie5, new Vector3(0,0,0), transform.rotation);
                Instantiate(cookie6, new Vector3(0,0,0), transform.rotation);
              }
            Destroy(gameObject);
              
              
              
              
            }
        }
      }
} 
