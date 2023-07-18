using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2move : MonoBehaviour
{
    private Vector3 target;
    public float x;
    public float y;
    public float z;
    private float set;
    public float speed;
    private float dangle;
    public float moveSpeed;
    [SerializeField] GameObject projectile;
     private Vector2 startPoint;
     public float c;
    public float Cooldown = 1f;
    public float CooldownCountdown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3 (x,y,z);
        startPoint = new Vector2(x,y);
        InvokeRepeating("Fire",0f,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (CooldownCountdown < 0f)
        {
            CooldownCountdown = Cooldown;
            c = c * -1;
        }
        else
        {
            CooldownCountdown -= Time.deltaTime;
        }
    }

     private void Fire()
     {
        if ((transform.position.x == x) && (transform.position.y == y) && (transform.position.z == z))
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

                dangle += c;

                if (dangle >= 360f)
                {
                    dangle = 0f;
                }    
        }
     }
}
