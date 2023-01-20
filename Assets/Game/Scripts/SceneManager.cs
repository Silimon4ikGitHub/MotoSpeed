using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("0");
    }
}
