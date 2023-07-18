using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene2 : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("gship1");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
            spawn.e1die = 0;
            spawn.e2die = 0;
            spawn.e3die = 0;
        }
        if (!player)
        {
            SceneManager.LoadScene(2);
            spawn.e1die = 0;
            spawn.e2die = 0;
            spawn.e3die = 0;
        }
    }
}
