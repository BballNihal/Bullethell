using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiecoll6 : MonoBehaviour
{
    public int hp;
    private int rhp;
    public static int dcookie6;
    // Start is called before the first frame update
    void Start()
    {
        rhp = hp;
        dcookie6 = 0;
        print (dcookie6);
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
            cookiecoll5.dcookie5 += 1;
            if (dcookie6 == 2)
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