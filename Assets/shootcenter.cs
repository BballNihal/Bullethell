using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootcenter : MonoBehaviour
{
    private Vector3 targetCenter;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        targetCenter = new Vector3(0f,0f,0f);
        Vector3 dir = targetCenter - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.Rotate(0,0,angle - 90f);
        Destroy(gameObject,10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
