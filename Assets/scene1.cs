using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene1 : MonoBehaviour
{
    private int nextScene;
    private int cntrlScene;
    // Start is called before the first frame update
    private void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        cntrlScene = 3;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(nextScene);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(cntrlScene);
        }
    }
}
