using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float runSpeed;
    public GameObject Projectile;
    public GameObject Projectile2;
    public float Cooldown = 3f;
    public float CooldownCountdown = 0f;
    [SerializeField]
    int numberOfProjectiles;
    public float bombs;
    public static float rbombs;
    [SerializeField]
    public Vector2 startPoint;
    public float radius;
    public float moveSpeed;
    void Start ()
    {
    body = GetComponent<Rigidbody2D>();
    rbombs = bombs;
    print(rbombs);
    }

    void Update()
    {
    startPoint = new Vector2(transform.position.x, transform.position.y);
    // Gives a value between -1 and 1
    horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
    vertical = Input.GetAxisRaw("Vertical"); // -1 is down
    if (CooldownCountdown < 0f)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                CooldownCountdown = Cooldown;
                Instantiate(Projectile, transform.position,transform.rotation);
                Instantiate(Projectile, transform.position,Quaternion.Euler(new Vector3(0, 0, -7)));
                Instantiate(Projectile, transform.position,Quaternion.Euler(new Vector3(0, 0, 7)));
            }
        }
        else
        {
            //Countdown the timer with the time past in the last frame
            CooldownCountdown -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (bombs > 0)
            {
                //GameObject[] enemies = GameObject.FindGameObjectsWithTag("bbullet2");
                //foreach(GameObject enemy in enemies)
                //GameObject.Destroy(enemy);
                float angleStep = 360f / numberOfProjectiles;
                float angle = 0f;

                for (int i = 0; i <= numberOfProjectiles - 1; i++) 
            
                {
                
                    float projectileDirXposition = startPoint.x + Mathf.Sin ((angle * Mathf.PI) / 180) * radius;
                    float projectileDirYposition = startPoint.y + Mathf.Cos ((angle * Mathf.PI) / 180) * radius;

                    Vector2 projectileVector = new Vector2 (projectileDirXposition, projectileDirYposition);
                    Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

                    var proj = Instantiate (Projectile2, startPoint, Quaternion.identity);
                    proj.GetComponent<Rigidbody2D> ().velocity = 
                    new Vector2 (projectileMoveDirection.x, projectileMoveDirection.y);

                    angle += angleStep;
                }
                bombs = bombs - 1;
                rbombs = bombs;
                print(rbombs);
            }
        }
    }

    void FixedUpdate()
    {
    if (horizontal != 0 && vertical != 0) 
     {
        
        horizontal *= moveLimiter;
        vertical *= moveLimiter;
     } 

    if (Input.GetKey(KeyCode.LeftShift))
        {
            runSpeed = 5f;
        }

    if (Input.GetKey(KeyCode.LeftShift) == false) 
        {
            runSpeed = 12f;
        }
    
        
    body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

}