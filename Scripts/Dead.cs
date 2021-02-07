using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameManager gm;
    public GameObject deadeffect;
    public Transform deadeffectpoistion;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Instantiate(deadeffect, deadeffectpoistion.position, Quaternion.identity);
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<AudioManager>().Play("Dead");
        }
    }
}
