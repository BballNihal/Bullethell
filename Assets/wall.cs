using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.gameObject.GetComponent<bbullet3>() != null)
        {
          Destroy(collision.gameObject);
        }
        if (collision.gameObject.GetComponent<gbullet>() != null)
        {
          Destroy(collision.gameObject);
        }
      }
}
