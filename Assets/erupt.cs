using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class erupt : MonoBehaviour
{
    public float killtime;
    public float extime;
    private Vector3 dir;
    public GameObject proj;
    IEnumerator shotCoroutine;
    private float r;
    [SerializeField]
    int spread;
    [SerializeField]
    int numberOfProjectiles;
    private float angle;
    private float anglerr;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,killtime);
        shotCoroutine = Shot();
        StartCoroutine(shotCoroutine);
        dir = new Vector3(0,1,0);
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

    }

    IEnumerator Shot()
    {
        yield return new WaitForSeconds(extime);
        

        for (int i = 0; i <= numberOfProjectiles - 1; i++)
        {
            r = Random.Range(0,spread + 1);
            anglerr = angle - (spread/2) + r - 90;
            Instantiate (proj, transform.position, Quaternion.Euler(new Vector3(0,0,anglerr)));
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
