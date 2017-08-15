using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainScript : MonoBehaviour {
	public Text scoreLbl;				//Лэйбл вывода очков




	public int timer;					//Таймер, отсчитывает секунды со старта игры
	public float score = 0.0001F;		//Главные очки
	const float bitcoinRate = 0.000004F;//Отношение биткоина к рублю
	public int ratio = 5;				//Коэффициент для нажатия

	void Start () 
	{
		
	}

	void Update () 
	{
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
