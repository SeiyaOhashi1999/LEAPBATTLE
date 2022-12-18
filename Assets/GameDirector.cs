using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
	GameObject timerText;
	GameObject scoreText;
	GameObject GameOverPanel;

	float time = 120.0f;
	int score = 0;

	public void ClashBullet()
	{
		this.score += 100;
	}

	public void ClashSword()
	{
		this.score += 100;
	}

	// Use this for initialization
	void Start ()
	{
		this.timerText = GameObject.Find("Time");
		this.scoreText = GameObject.Find("Score");
		this.GameOverPanel = GameObject.Find("GameOverPanel");
		this.GameOverPanel.GetComponent<Image>().enabled = false;
	}

	// Update is called once per frame
	void Update ()
	{
		this.time -= Time.deltaTime;
		this.timerText.GetComponent<Text>().text = this.time.ToString("F1") + "s";
		this.scoreText.GetComponent<Text>().text = this.score.ToString() + "Point";
		if(this.time < 0.0f)
		{
			this.GameOverPanel.GetComponent<Image>().enabled = true;
			this.timerText.GetComponent<Text>().text = "0.0s";
		}
		//this.GameOverText.GetComponent<Text>().text = "GameOver";
	}
}
