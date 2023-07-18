using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3move : MonoBehaviour
{
    public float ispeed = 8.9f;
    public float speed = 5f;
    private float set;
    [SerializeField] 
    private Vector3 targettr = new Vector3(16.5f, 8.5f, 0);
    [SerializeField] 
    private Vector3 targetbr = new Vector3(16.5f, -8.5f, 0);
    [SerializeField] 
    private Vector3 targetbl = new Vector3(-16.5f, -8.5f, 0);
    [SerializeField] 
    private Vector3 targettl = new Vector3(-16.5f, 8.5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        //8.5 16.5
         if ((transform.position.x == -16.5f) && (transform.position.y == -12.95f) && (transform.position.z == 0f))
        {
            set = 1;
        }
        if ((transform.position.x == 16.5f) && (transform.position.y == 12.95f) && (transform.position.z == 0f))
        {
            set = 3;
        }
        if ((transform.position.x == 19f) && (transform.position.y == -8.5f) && (transform.position.z == 0f))
        {
            set = 4;
        }
        if ((transform.position.x == -19) && (transform.position.y == 8.5f) && (transform.position.z == 0f))
        {
            set = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (set == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetbl, Time.deltaTime * ispeed);
            if (transform.position == targetbl)
            {
                set = 2;
            }
        }
        if (set == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, targettl, Time.deltaTime * speed);
            if (transform.position == targettl)
            {
                set = 3;
            }
        }
        if (set == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, targettr, Time.deltaTime * ispeed);
            if (transform.position == targettr)
            {
                set = 4;
            }
        }
        if (set == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetbr, Time.deltaTime * speed);
            if (transform.position == targetbr)
            {
                set = 1;
            }
        }
    }
}
