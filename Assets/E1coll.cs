using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1coll : MonoBehaviour
{
    public int hp;
    private int rhp;
    // Start is called before the first frame update
    void Start()
    {
        rhp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.x <= -19) || (transform.position.x >= 19))
        { 
            spawn.e1die += 1;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.gameObject.GetComponent<gbullet>() != null)
        {
          Destroy(collision.gameObject);
          rhp = hp--;
          if (rhp == 0)
            {
            spawn.e1die += 1;
            Destroy(gameObject);
            }
        }
      }
}
