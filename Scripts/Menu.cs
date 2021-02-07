using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<AudioManager>().Play("Beep");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("QUITTING");
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            SceneManager.LoadScene("Hard");
        }
    }
}
