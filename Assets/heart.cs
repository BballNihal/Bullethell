using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    [SerializeField]
    private float req;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pcoll.rhpp < req)
        {
            Destroy(gameObject);
        }

    }
}
