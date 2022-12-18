using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoppingcarscore : MonoBehaviour
{
	GameObject director;
	//音追加
	public AudioClip zangekikoukaon;
	//AudioSource aud;
	public GameObject zangekieffect1;

	public GameObject zangekieffect2;

	// Use this for initialization
	void Start ()
	{
		this.director = GameObject.Find("GameDirector");
		//this.aud = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Zangeki")
		{
			this.director.GetComponent<GameDirector>().ClashBullet();
			//Debug.Log("mimi");

			AudioSource.PlayClipAtPoint(zangekikoukaon, transform.position);
			Instantiate(zangekieffect1, this.transform.position, Quaternion.identity);
			Destroy(this.gameObject);
			Destroy(other.gameObject);

		}

		else
		{
			Instantiate(zangekieffect2, this.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
		}

	}
}
