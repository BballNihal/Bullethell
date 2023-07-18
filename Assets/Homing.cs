using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : MonoBehaviour
{
    private GameObject player;
    private Vector3 targetPlayer;
    [SerializeField] private float speed = 1f;
    private Vector2 direction; 
    private float Cooldown = 0.01f;
    private float CooldownCountdown = 0f;
    private float  playdistance = 10f;
    private float distance;

    void Start()
    { // Creating initial targeting
        player = GameObject.Find("gship1");
        targetPlayer = player.transform.position;
        direction = new Vector2(Random.Range(-50,50),Random.Range(-15,15));
        direction = direction.normalized*speed;
        print (direction.x);
        print (direction.y);
        distance = (targetPlayer - transform.position).magnitude;
         //Destroy(gameObject,10f);
    }



    void Update()
    { 
        transform.Translate(direction * Time.deltaTime);
        
    }

}
