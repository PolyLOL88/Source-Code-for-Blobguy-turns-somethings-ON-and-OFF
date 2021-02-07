using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameManager gm;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.LoadNextLevel();
        }
    }
}
