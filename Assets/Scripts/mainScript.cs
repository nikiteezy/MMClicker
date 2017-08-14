using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mainScript : MonoBehaviour {
	public Text scoreLbl;
	public int timer;
	public float score = 0.0001F;
	const float bitcoinRate = 0.000004F;
	public int ratio = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreTimeUp ();
		timeScoreUp ();


	}
	void scoreTimeUp()
	{
		float bitcoinScore = (float)(score*bitcoinRate);
		scoreLbl.text = "" + bitcoinScore;
	}
	void timeScoreUp()
	{
		if (timer < (int)Time.time) 
		{
			timer = (int)Time.time;
			score++;
		} 
	}

	public void OnClickCoin()
	{
		score += ratio;
	}
}
