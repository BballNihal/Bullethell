using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2 : MonoBehaviour
{
    public float Cooldown = 3f;
    public float CooldownCountdown = 0f;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        if (CooldownCountdown < 0f)
        {
            CooldownCountdown = Cooldown;
            Instantiate(bullet, transform.position,transform.rotation);
        }
        else
        {
            CooldownCountdown -= Time.deltaTime;
        }
    }
}
