using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanScore : MonoBehaviour
{
	GameObject director;
	//音追加
	public AudioClip zangekikoukaon;
	//AudioSource aud;
	public GameObject hadoueffect1;

	public GameObject hadoueffect2;

	// Use this for initialization
	void Start ()
	{
		this.director = GameObject.Find("GameDirector");
		//this.aud = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Hadou")
		{
			this.director.GetComponent<GameDirector>().ClashBullet();
			//Debug.Log("mimi");

			AudioSource.PlayClipAtPoint(zangekikoukaon, transform.position);
			Instantiate(hadoueffect1, this.transform.position, Quaternion.identity);
			Destroy(this.gameObject);
			Destroy(other.gameObject);

		}

		else
		{
			Instantiate(hadoueffect2, this.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
		}

	}
}
