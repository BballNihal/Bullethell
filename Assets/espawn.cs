using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espawn : MonoBehaviour
{
    public GameObject Projectile;
    public float Cooldown = 3f;
    public float CooldownCountdown = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
        }

    // Update is called once per frame
    void Update()
    {
         if (CooldownCountdown < 0f)
        {
            CooldownCountdown = Cooldown;
            Instantiate(Projectile, transform.position,transform.rotation);
        }
    else
        {
            //Countdown the timer with the time past in the last frame
            CooldownCountdown -= Time.deltaTime;
        }
    }
}
