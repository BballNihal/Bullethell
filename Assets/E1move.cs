using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1move : MonoBehaviour
{
    private Vector3 target;
    public float x;
    public float y;
    public float z;
    private float set;
    public float speed;
    public float rl;
    // Start is called before the first frame update
    void Start()
    {
        set = 1;
        target = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        if (set == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
            if ((transform.position.x == x) && (transform.position.y == y) && (transform.position.z == z))
            {
                set = set + 1;
            }
        }
        else
        {
            if (rl == 1)
            {
                GetComponent<Rigidbody2D>().velocity = -transform.right * speed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            }
        }
    }
}
