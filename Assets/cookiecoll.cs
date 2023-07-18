using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiecoll : MonoBehaviour
{
    public int hp;
    private int rhp;
    public GameObject cookie2;
    public GameObject cookie3;
    // Start is called before the first frame update
    void Start()
    {
        rhp = hp;
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
              Destroy(gameObject);
              Instantiate(cookie2, new Vector3(0,0,0), transform.rotation);
              Instantiate(cookie3, new Vector3(0,0,0), transform.rotation);
            }
        }
      }
} 
