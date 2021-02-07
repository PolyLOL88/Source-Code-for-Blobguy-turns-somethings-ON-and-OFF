using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDead : MonoBehaviour
{
    public GameObject dead;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dead.SetActive(false);
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            dead.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            dead.SetActive(false);
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            dead.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            dead.SetActive(false);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            dead.SetActive(true);
        }


    }
}
