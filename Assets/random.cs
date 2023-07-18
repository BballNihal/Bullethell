using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] private float speed = 1f;
    private Vector3 target = new Vector3(0, 8);
 

    // Start is called before the first frame update
    void Start()
    {
        direction = (transform.position - target).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction*Time.deltaTime);
    }
}
