using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
	public float speed;
	//public float dropSpeed = -0.03f;

	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(Vector3.one);
		transform.Translate(Vector3.down * speed, Space.World);
		//transform.Translate(0, this.dropSpeed, 0);
		if(transform.position.y < -1.0f)
		{
			Destroy(gameObject);
		}
	}
}
