using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScore : MonoBehaviour
{
	GameObject director;
	//音追加
	public AudioClip explosionSE;
	//AudioSource aud;
	public GameObject particleObject1;

	public GameObject particleObject2;

	// Use this for initialization
	void Start ()
	{
		this.director = GameObject.Find("GameDirector");
		//this.aud = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Bullet")
		{
			this.director.GetComponent<GameDirector>().ClashBullet();
			//Debug.Log("mimi");

			AudioSource.PlayClipAtPoint(explosionSE, transform.position);
			Instantiate(particleObject1, this.transform.position, Quaternion.identity);
			Destroy(this.gameObject);
			Destroy(other.gameObject);

		}

		else
		{
			Instantiate(particleObject2, this.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
		}

	}
}
