using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
private GameObject player;
private Vector3 targetPlayer;

// Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("gship1");
        targetPlayer = player.transform.position;
        Vector3 dir = targetPlayer - transform.position;
        dir = player.transform.InverseTransformDirection(dir);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.Rotate(0,0,angle - 90f);
        Destroy(gameObject,10f);

    }

// Update is called once per frame
    void Update()
    {
        
        
    }
}
