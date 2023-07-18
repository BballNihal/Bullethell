using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeBullet : MonoBehaviour
{
    private GameObject player;
    private Vector3 targetPlayer;
    [SerializeField] private float speed = 1f;
    private Vector2 direction; 
    private float Cooldown = 0.3f;
    private float CooldownCountdown = 0f;
    private float  playdistance = 10f;
    private float distance;

    void Start()
    { // Creating initial targeting
        player = GameObject.Find("gship1");
        targetPlayer = player.transform.position;
        direction = (targetPlayer - transform.position).normalized * speed;
        distance = (targetPlayer - transform.position).magnitude;
        // Destroy(gameObject,10f);
        print( targetPlayer);
        print (distance);
    }



    void Update()
    { 
        //close homing 
        if (distance >= 0)
        {
            distance = (targetPlayer - transform.position).magnitude;
            //inaccuracy
            if (CooldownCountdown < 0f)
            {
                CooldownCountdown = Cooldown;
                player = GameObject.Find("gship1");
                targetPlayer = player.transform.position;
                direction = (targetPlayer - transform.position).normalized * speed;
            }
            else
            {
             CooldownCountdown -= Time.deltaTime;
            }

        }
        
        transform.Translate(direction*Time.deltaTime);
    }

}
