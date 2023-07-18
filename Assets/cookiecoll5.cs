using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiecoll5 : MonoBehaviour
{
    public int hp;
    private int rhp;
    public static int dcookie5;
    // Start is called before the first frame update
    void Start()
    {
        rhp = hp;
        dcookie5 = 0;
        print (dcookie5);
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
            cookiecoll4.dcookie4 += 1;
            cookiecoll6.dcookie6 += 1;
            if (dcookie5 == 2)
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