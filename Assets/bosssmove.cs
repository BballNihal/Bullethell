using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosssmove : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField] 
    private Vector3 target = new Vector3(0, 0, 0);
    IEnumerator cookieCoroutine;
    public GameObject cookie1;
    // Start is called before the first frame update
    void Start()
    {
        cookieCoroutine = cookie();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if ((transform.position.x == 0) && (transform.position.y == 0) && (transform.position.z == 0))
        {
            StartCoroutine(cookieCoroutine);
        }

        if ((cookiecoll6.dcookie6 == 2) || (cookiecoll5.dcookie5 == 2) || (cookiecoll2.dcookie2 == 2))
        {
            Destroy(gameObject);
        }
    }

    IEnumerator cookie()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(cookie1, transform.position, transform.rotation);
    }
}
