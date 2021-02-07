using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;
	public float startTimebtwshots;
	private float timebtwshots;

	// Update is called once per frame
	void Update()
	{
		timebtwshots -= timebtwshots;
		if (Input.GetKeyDown(KeyCode.Space) && timebtwshots <= 0)
		{
			Shoot();
        }
        else
        {
			timebtwshots -= Time.deltaTime;
        }
	}

	void Shoot()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		timebtwshots = startTimebtwshots;
		FindObjectOfType<AudioManager>().Play("Shoot");
	}
}
