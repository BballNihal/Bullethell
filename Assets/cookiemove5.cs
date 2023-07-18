using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiemove5 : MonoBehaviour
{
    private float set;
    [SerializeField]
    float speed;
    [SerializeField] 
    private Vector3 target = new Vector3(0, 9, 0);
    [SerializeField]
    private Vector2 center = new Vector2(0 ,0);
    [SerializeField]
    private float Radius = 8f;
    private float mangle;
    [SerializeField]
    private float RotateSpeed;
    public GameObject verticalbullet;
    [SerializeField]
    private int Projectiles;
    public float Cooldown = 1f;
    private float CooldownCountdown = 0f;
    [SerializeField]
    private float xpos;
    [SerializeField]
    private float ypos;
    [SerializeField]
    private float zpos;
    

    // Start is called before the first frame update
    void Start()
    {
        set = 0;
        mangle = 2.094395f;
    }

    // Update is called once per frame
    void Update()
    {
        if (set == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
            if ((transform.position.x == xpos) && (transform.position.y == ypos) && (transform.position.z == zpos))
            {
                set = 1;
                print(set);
            }
        }
        if (set == 1)
        {
            mangle += RotateSpeed * Time.deltaTime;
            var offset = new Vector2(Mathf.Sin(mangle), Mathf.Cos(mangle)) * Radius;
            transform.position = center + offset;
        }
        if (CooldownCountdown < 0f)
                {
                    CooldownCountdown = Cooldown;
                    for (int i = 0; i <= Projectiles - 1; i++)
                    {
                        Instantiate(verticalbullet, new Vector2(Random.Range(-18f,18f), 10), Quaternion.Euler(0,0,180));
                    }
                }
                else
                {
                    CooldownCountdown -= Time.deltaTime;
                }
        
       

    }
}