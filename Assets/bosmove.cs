using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosmove : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField] 
    private Vector3 target = new Vector3(0, 0, 0);
    public GameObject boss;
    IEnumerator destructCoroutine;
    
    // Start is called before the first frame update
    void Start()
    {
        destructCoroutine = Destroy();
        StartCoroutine(destructCoroutine);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2f);
        if (transform.position == target)
        {
            Instantiate(boss);
            Destroy(gameObject);
        }
    }
}
