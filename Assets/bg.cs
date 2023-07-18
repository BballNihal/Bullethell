using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    
    [SerializeField]
    private float Cooldown;
    [SerializeField]
    private float CooldownCountdown;
    public GameObject bgg;
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
                    Instantiate(bgg, new Vector3(0,96*2,0),transform.rotation);
                }
                else
                {
                    CooldownCountdown -= Time.deltaTime;
                }
    }
}
