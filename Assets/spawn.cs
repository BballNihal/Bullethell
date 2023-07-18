using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField]
    private Vector3 bossloc = new Vector3 (0,0,0);
    public GameObject boss;
    public GameObject Spawner1E1;
    public GameObject Spawner1E2;
    public GameObject Spawner1E3;
    public GameObject Spawner1E4;
    public GameObject E2t1;
    public GameObject E2t2;
    public GameObject E2t3;
    public GameObject E3t1;
    public GameObject E3t2;
    public GameObject E3t3;
    public GameObject E3t4;
    public static int e1die;
    public static int e2die;
    public static int e3die;

    void Start()
    {
        print(e1die);
        print(e2die);
        print(e3die);
        Instantiate(Spawner1E1,new Vector3(-10f,12f,0f), transform.rotation);
        Instantiate(Spawner1E2,new Vector3(-13f,13.5f,0f), transform.rotation);
        Instantiate(Spawner1E3,new Vector3(13f,13.5f,0f), transform.rotation);
        Instantiate(Spawner1E4,new Vector3(10f,12f,0f), transform.rotation);
        //Instantiate(boss,bossloc,transform.rotation);
    }

    void Update()
    {
        if (e1die >= 40)
        {
            Instantiate(E2t1, new Vector3(25,7,0), transform.rotation);
            Instantiate(E2t2, new Vector3(-25,7,0), transform.rotation);
            Instantiate(E2t3, new Vector3(0,12,0), transform.rotation);
            e1die = -999999;
        }
        if (e2die >= 3)
        {
            Instantiate(E3t1, new Vector3(-16.5f,-12.95f,0f), transform.rotation);
            Instantiate(E3t3, new Vector3(16.5f,12.95f,0f), transform.rotation);
            Instantiate(E3t4, new Vector3(19f,-8.5f,0f), transform.rotation);
            Instantiate(E3t2, new Vector3(-19f,8.5f,0f), transform.rotation);
            e2die = -999999;
        }
        if (e3die >= 4)
        {
            Instantiate(boss,bossloc,transform.rotation);
            e3die = -999999;
        }
    }
}
