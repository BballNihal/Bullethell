using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiemove6 : MonoBehaviour
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
    public GameObject diagbullet;
    [SerializeField]
    private float xpos;
    [SerializeField]
    private float ypos;
    [SerializeField]
    private float zpos;
    public Vector2 startPoint;
    public Vector2 startPoint2;
    public float moveSpeed;
    private float dangle;

    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire",0f,0.2f);
        InvokeRepeating("Fire2",0f,0.2f);
        set = 0;
        mangle = 4.18879f;
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
}

private void Fire()
{
    if (set == 1)
    {
   
            for (int i=0; i<= 2; i++)
                {
                    float bulDirX = transform.position.x + Mathf.Sin(((dangle + 120f * i) * Mathf.PI)/180f);
                    float bulDirY = transform.position.y + Mathf.Cos(((dangle + 120f * i) * Mathf.PI)/180f);

                    Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
                    Vector2 bulDir = (bulMoveVector - transform.position).normalized * moveSpeed;

                    GameObject bul = diagbullet;
                    bul.transform.position = transform.position;
                    var projec = Instantiate (diagbullet, startPoint, Quaternion.identity);
                    projec.GetComponent<Rigidbody2D> ().velocity = new Vector2 (bulDir.x, bulDir.y);
                }

                dangle += 21f;

                if (dangle >= 360f)
                {
                    dangle = 0f;
                 
        }
    }
}
private void Fire2()
{
    if (set == 1)
    {
        for (int i=0; i<= 2; i++)
                {
                    float bulDirX = transform.position.x + Mathf.Sin(((dangle + 120f * i) * Mathf.PI)/180f);
                    float bulDirY = transform.position.y + Mathf.Cos(((dangle + 120f * i) * Mathf.PI)/180f);

                    Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
                    Vector2 bulDir = (bulMoveVector - transform.position).normalized * moveSpeed;

                    GameObject bul = diagbullet;
                    bul.transform.position = transform.position;
                    var projec = Instantiate (diagbullet, startPoint2, Quaternion.identity);
                    projec.GetComponent<Rigidbody2D> ().velocity = new Vector2 (bulDir.x, bulDir.y);
                }

                dangle += 21f;

                
    }
}
}