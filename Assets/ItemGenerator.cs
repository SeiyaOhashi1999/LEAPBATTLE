using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGenerator : MonoBehaviour
{
	public GameObject cubePrefab;
	public GameObject spherePrefab;
	public GameObject Hydrant;
	public GameObject Can;
	public GameObject Shoppingcar;
	float span = 0.3f;
	float delta = 0;
	//int ratio = 5;

	//public Text Scoretext;
	//private int score = 0;

	//void OnTriggerEnter(Collider other)
	//{
		//Score += 10;
		//Scoretext.text = string.Format("Score:{0}", score);
	//}


	// Update is called once per frame
	void Update ()
	{
		this.delta += Time.deltaTime;
		if(this.delta > this.span)
		{
			this.delta = 0;
			GameObject item;
			int dice = Random.Range(1,15);
			if(dice <= 5)
			{
				//item = Instantiate(cubePrefab) as GameObject;
				item = Instantiate(Hydrant) as GameObject;
			}
			else if(6 <= dice && dice <= 10)
			{
				item = Instantiate(Shoppingcar) as GameObject;
			}
			else
			{
				item = Instantiate(Can) as GameObject;
			}

			//float x = Random.Range(-5,5);
			//float z = Random.Range(3,8);
			//item.transform.position = new Vector3(x, 10, z);
			float x = Random.Range(-300,-350);
			float z = Random.Range(5,15);
			item.transform.position = new Vector3(x, 80, z);
		}
		if(transform.position.y < -69.0f)
		{
			Destroy(gameObject);
		}
	}
}
