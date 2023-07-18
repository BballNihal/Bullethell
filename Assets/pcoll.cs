using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcoll : MonoBehaviour
{
  public float hp;
  public static float rhpp;
  [SerializeField]
  int numberOfProjectiles;

  [SerializeField]
  public Vector2 startPoint;
  public float radius;
  public float moveSpeed;
  public GameObject Projectile;
  [SerializeField]
  private float icooldown;
  [SerializeField]
  private float icooldowntimer;
  // Start is called before the first frame update
    void Start()
    {
      rhpp = hp;
      print(rhpp);
      print("hp is " + rhpp);
    }

    // Update is called once per frame
    void Update()
    {
        {
          icooldowntimer -= Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
      {
        if (icooldowntimer < 0f)
        {
          if (collision.gameObject.GetComponent<bbullet2>() != null)
          {
            icooldowntimer = icooldown;
            Destroy(collision.gameObject);
              float angleStep = 360f / numberOfProjectiles;
              float angle = 0f;

              for (int i = 0; i <= numberOfProjectiles - 1; i++) 
              
              {
                startPoint = new Vector2(transform.position.x, transform.position.y);
                float projectileDirXposition = startPoint.x + Mathf.Sin ((angle * Mathf.PI) / 180) * radius;
                float projectileDirYposition = startPoint.y + Mathf.Cos ((angle * Mathf.PI) / 180) * radius;

                Vector2 projectileVector = new Vector2 (projectileDirXposition, projectileDirYposition);
                Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

                var proj = Instantiate (Projectile, startPoint, Quaternion.identity);
                proj.GetComponent<Rigidbody2D> ().velocity = 
                new Vector2 (projectileMoveDirection.x, projectileMoveDirection.y);

                angle += angleStep; 
              }
              hp = hp - 1;
              rhpp = hp;
              print(rhpp);
              if (rhpp <= -1)
              {
                Destroy(gameObject);
              }
            
          }
        }

      }
} 
