using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1spawnkill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn.e1die >= 35)
        {   
            Destroy(gameObject);
        }
    }
}
