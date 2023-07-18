using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmove1 : MonoBehaviour
{
    public float phase;
    private float xdistance;
    public float speed;
    private float rspeed = 10.0f;
    private float ptimer;
    private float RotateSpeed = 2f;
    private float Radius = 9f;
    private float Radius2 = 0.5f;
    private Vector2 center;
    private Vector2 center2 = new Vector2(0,8);
    private float angle;
    private float mangle;
    public float Cooldown3 = 3f;
    public float Cooldown4 = 3f;
    public float CooldownCountdown3 = 0f;
    public float CooldownCountdown4 = 0f;
    public GameObject bullet34;
    public GameObject bullet4;
    public float Cooldown5 = 3f;
    public float CooldownCountdown5 = 0f;
    public GameObject bullet12;
    public float Cooldown = 3f;
    public float CooldownCountdown = 0f;
    public GameObject bullet6;
    public float Cooldown6 = 3f;
    public float CooldownCountdown6 = 0f;
    public GameObject bullet2;
    public float Cooldown2 = 3f;
    public float CooldownCountdown2 = 0f;


    [SerializeField] 
    private Vector3 target = new Vector3(0, 0, 0);
    
    
    [SerializeField]
    int numberOfProjectiles;

    [SerializeField]
    int numberOfProjectiles5;

    [SerializeField]
    GameObject projectile;
    public Vector2 startPoint;
    public float radius;
    public float moveSpeed;
    public float moveSpeed5;

    private float dangle;
    private Vector2 bulletMoveDirection;
    private float spread;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Fire",0f,0.1f);
        phase = 0;
        Pphase();
        
    }
        
    void Pphase()
    {
        if (phase == 6)
        {
            phase = 0;
        }
        phase = phase + 1;
        print(phase);
        ptimer = 10.0f;
    }
    // Update is called once per frame
    void Update()
    {
        startPoint = new Vector2(transform.position.x, transform.position.y);
        ptimer -= Time.deltaTime;
        if (ptimer>0.0f)
        {
            if ((phase == 1))
            {
                float xdistance = gameObject.transform.position.x;
                if (xdistance == 0)
                {
                    GetComponent<Rigidbody2D>().velocity = transform.right * speed;
                }
                else if (xdistance >= 12)
                {
                    GetComponent<Rigidbody2D>().velocity = -transform.right * speed;
                }
                else if (xdistance <= -12)
                {
                    GetComponent<Rigidbody2D>().velocity = transform.right * speed;
                }   
                if (CooldownCountdown < 0f)
                {
                    CooldownCountdown = Cooldown;
                    Instantiate(bullet12, transform.position,transform.rotation);
                }
                else
                {
                    CooldownCountdown -= Time.deltaTime;
                }
               
            }
            else if ((phase == 2))
            {
                float xdistance = gameObject.transform.position.x;
                if (xdistance == 0)
                {
                    GetComponent<Rigidbody2D>().velocity = -transform.right * speed;
                }
                else if (xdistance >= 12)
                {
                    GetComponent<Rigidbody2D>().velocity = -transform.right * speed;
                }
                else if (xdistance <= -12)
                {
                    GetComponent<Rigidbody2D>().velocity = transform.right * speed;
                }   
                
                if (CooldownCountdown2 < 0f)
                {
                    CooldownCountdown2 = Cooldown2;
                    Instantiate(bullet2, transform.position,transform.rotation);
                }
                else
                {
                    CooldownCountdown2 -= Time.deltaTime;
                }
                 
            }
            else if ((phase == 3))
            {
                mangle += RotateSpeed * Time.deltaTime;
 
                var offset = new Vector2(Mathf.Sin(mangle), Mathf.Cos(mangle)) * Radius;
                transform.position = center + offset;

                if (CooldownCountdown3 < 0f)
                    {
                        CooldownCountdown3 = Cooldown3;
                        Instantiate(bullet34, transform.position,transform.rotation);
                    }
                else
                    {
                        CooldownCountdown3 -= Time.deltaTime;
                    }
            }
            else if ((phase == 4))
            {
                mangle -= RotateSpeed * 17.831f * Time.deltaTime;
 
                var offset = new Vector2(Mathf.Sin(mangle), Mathf.Cos(mangle)) * Radius2;
                transform.position = center2 + offset;

                if (CooldownCountdown4 < 0f)
                    {
                        CooldownCountdown4 = Cooldown4;
                        Instantiate(bullet4, transform.position,transform.rotation);
                    }
                else
                    {
                        CooldownCountdown4 -= Time.deltaTime;
                    }
            }    
            else if ((phase == 5))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0f,0f,0f), Time.deltaTime * rspeed);
                if (CooldownCountdown5 < 0f)
                {
                    CooldownCountdown5 = Cooldown5;
                    GetComponent<Rigidbody2D>().velocity = transform.right * speed * 0f;
                    float angleStep = 360f / numberOfProjectiles5;
		            float angle = 0f;

	                for (int i = 0; i <= numberOfProjectiles5 - 1; i++) 
                        {	
			                float projectileDirXposition = startPoint.x + Mathf.Sin ((angle * Mathf.PI) / 180) * radius;
                            float projectileDirYposition = startPoint.y + Mathf.Cos ((angle * Mathf.PI) / 180) * radius;

                            Vector2 projectileVector = new Vector2 (projectileDirXposition, projectileDirYposition);
                            Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed5;

                            var proj = Instantiate (projectile, startPoint, Quaternion.identity);
                            proj.GetComponent<Rigidbody2D> ().velocity = new Vector2 (projectileMoveDirection.x, projectileMoveDirection.y);

                            angle += angleStep;
                        }
                }
                else
                    {
                        CooldownCountdown5 -= Time.deltaTime;
                    }
            }
            else if ((phase == 6))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(17f,9.2f,0f), Time.deltaTime * rspeed);
                if (CooldownCountdown6 < 0f)
                {
                    CooldownCountdown6 = Cooldown6;
                    Instantiate(bullet6, transform.position,transform.rotation);
                    
                }
                else
                {
                    CooldownCountdown6 -= Time.deltaTime;
                }
                
                
            }
            
        }
        if (ptimer <= 0.0f)
        {
            GetComponent<Rigidbody2D>().velocity = transform.right * speed * 0f;
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * rspeed);
            if ((transform.position.x == 0) && (transform.position.y == 9) && (transform.position.z == 0))
            {
                GetComponent<Rigidbody2D>().velocity = transform.right * speed * 0f;
                float angleStep = 360f / numberOfProjectiles;
		        float angle = 0f;

		for (int i = 0; i <= numberOfProjectiles - 1; i++) 
        {	
			float projectileDirXposition = startPoint.x + Mathf.Sin ((angle * Mathf.PI) / 180) * radius;
			float projectileDirYposition = startPoint.y + Mathf.Cos ((angle * Mathf.PI) / 180) * radius;

			Vector2 projectileVector = new Vector2 (projectileDirXposition, projectileDirYposition);
			Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * moveSpeed;

			var proj = Instantiate (projectile, startPoint, Quaternion.identity);
			proj.GetComponent<Rigidbody2D> ().velocity = new Vector2 (projectileMoveDirection.x, projectileMoveDirection.y);

			angle += angleStep;
        }
                mangle = 0.0f;
                Pphase();
            }
        }

    }


    private void Fire()
    {
        if ((phase == 5))
        {
            if ((transform.position.x == 0) && (transform.position.y == 0) && (transform.position.z == 0))
            {
                for (int i=0; i<= 3; i++)
                {
                    float bulDirX = transform.position.x + Mathf.Sin(((dangle + 90f * i) * Mathf.PI)/180f);
                    float bulDirY = transform.position.y + Mathf.Cos(((dangle + 90f * i) * Mathf.PI)/180f);

                    Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
                    Vector2 bulDir = (bulMoveVector - transform.position).normalized * moveSpeed;

                    GameObject bul = projectile;
                    bul.transform.position = transform.position;
                    var projec = Instantiate (projectile, startPoint, Quaternion.identity);
                    projec.GetComponent<Rigidbody2D> ().velocity = new Vector2 (bulDir.x, bulDir.y);
                }

                dangle += 5f;

                if (dangle >= 360f)
                {
                    dangle = 0f;
                }    
            }
        }
    }
}

