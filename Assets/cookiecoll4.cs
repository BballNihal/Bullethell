using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiecoll4 : MonoBehaviour
{
    public int hp;
    private int rhp;
    public static int dcookie4;
    // Start is called before the first frame update
    void Start()
    {
        rhp = hp;
        dcookie4 = 0;
        print (dcookie4);
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
            cookiecoll6.dcookie6 += 1;
            cookiecoll5.dcookie5 += 1;
            if (dcookie4 == 2)
                {
                string name = "bosss";
                GameObject go = GameObject.Find (name);
                if (go)
                    {
                        Destroy (go.gameObject);
                    }
                }               
            Destroy(gameObject);
            }
        }
      }
} 

