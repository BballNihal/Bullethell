using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotato : MonoBehaviour
{
    private float spinna;
    public float degs;
    // Start is called before the first frame update
    void Start()
    {
        spinna = Random.Range(-degs,degs);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,spinna);
    }
}
