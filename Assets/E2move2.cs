using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2move2 : MonoBehaviour
{
    private Vector3 target;
    public float x;
    public float y;
    public float z;
    private float set;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3 (x,y,z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }

}
