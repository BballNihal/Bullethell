using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public float speed;
    void Update()
{
    GetComponent<Rigidbody2D>().velocity = -transform.right * speed;
}
}
