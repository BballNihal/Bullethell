using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot3 : MonoBehaviour

{
    [SerializeField]
    int numberOfProjectiles;
    public GameObject proj;
    IEnumerator shotCoroutine;
    private GameObject player;
    private Vector3 targetPlayer;
    private float angle;
    private float angler;
    private float r;
    private float anglerr;
    [SerializeField]
    int spread;
    public float des1;
    public float des2;


    // Start is called before the first frame update
    void Start()
    {
        //0.1 0.05 ; 0.5 0.4
        Destroy(gameObject, des1);
        shotCoroutine = Shot();
        StartCoroutine(shotCoroutine);
        player = GameObject.Find("gship1");
        targetPlayer = player.transform.position;
        Vector3 dir = targetPlayer - transform.position;
        dir = player.transform.InverseTransformDirection(dir);
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        angler = angle - 90;
    }

    IEnumerator Shot()
    {
        yield return new WaitForSeconds(des2);
        
        if (numberOfProjectiles > 1)
        {
        for (int i = 0; i <= numberOfProjectiles - 1; i++)
        {
            r = (i) * spread/(numberOfProjectiles-1);
            anglerr = angler - spread/2 +r;
            Instantiate (proj, transform.position, Quaternion.Euler(new Vector3(0,0,anglerr)));
        }
        }
        else
        {
            Instantiate (proj, transform.position, Quaternion.Euler(new Vector3(0,0,angler)));
        }
    }
}