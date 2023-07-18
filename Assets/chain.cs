using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chain : MonoBehaviour
{
private GameObject player;
private Vector3 targetPlayer;
[SerializeField] private float speed = 2f;
private Vector3 direction; 
public float Cooldown = 3f;
public float CooldownCountdown = 0f;
public GameObject chaintr;

// Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,5f);
        player = GameObject.Find("gship1");
        targetPlayer = player.transform.position;
        direction = (targetPlayer - transform.position).normalized * speed;
        
    }

// Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);

        if (CooldownCountdown < 0f)
        {
            CooldownCountdown = Cooldown;
            Instantiate(chaintr, transform.position,transform.rotation);
        }
        else
        {
            CooldownCountdown -= Time.deltaTime;
        }
    }
}
