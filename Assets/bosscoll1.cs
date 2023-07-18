using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bosscoll1 : MonoBehaviour
{
    public int hp;
    private int rhp;
    public GameObject bosss;
    public bar bar;

    // Start is called before the first frame update
    void Start()
    {
        rhp = hp;
        bar.SetMaxHealth(hp);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.gameObject.GetComponent<gbullet>() != null)
        {
          Destroy(collision.gameObject);
          rhp = hp--;
          bar.SetHealth(rhp);
          print(rhp);
          if (rhp == 0)
            {
              Instantiate(bosss,transform.position,transform.rotation);
              Destroy(gameObject);
            }
          
        }
      }
}
