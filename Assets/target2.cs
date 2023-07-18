using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target2 : MonoBehaviour
{
private GameObject player;
private Vector3 targetPlayer;
[SerializeField] private float speed = 2f;
public Vector3 direction;

// Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("gship1");
        targetPlayer = player.transform.position;
        direction = (targetPlayer - transform.position).normalized;

        Destroy(gameObject,10f);

    }

// Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
