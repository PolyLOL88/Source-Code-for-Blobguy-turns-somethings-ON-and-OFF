using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
	public int health = 100;

	public GameObject deathEffect;
	public GameManager gm;
	public Transform diepos;
	public AI ai;
	public Text bosstext;

	public void TakeDamage(int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
		FindObjectOfType<AudioManager>().Play("Beep");
		gm.LoadNextLevel();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
			gm.EndGame();
			Destroy(collision.gameObject);
			Instantiate(deathEffect, diepos.position, Quaternion.identity);
        }
    }

    private void Update()
    {
        if(health == 150)
        {
			ai.speed = 1.5f;
        }

		if (health == 100)
		{
			ai.speed = 2f;
		}

		bosstext.text = "Boss Health:" + health;
	}

}

