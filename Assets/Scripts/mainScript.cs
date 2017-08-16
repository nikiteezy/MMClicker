﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainScript : MonoBehaviour {
	public Text scoreLbl;				//Лэйбл вывода очков
	public GameObject shopPanel;


	int timer;							//Таймер, отсчитывает секунды со старта игры
    long score = 0;						//Главные очки
	const float bitcoinRate = 0.000004F;//Отношение биткоина к рублю
	int ratio = 5;						//Коэффициент для нажатия
	int passiveBonus = 0;
	int clickBonus = 1;

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
			score += passiveBonus;
		} 
	}

	public void OnClickCoin()
	{
		score += ratio*clickBonus;
	}

	public void clicOnShopBtn()
	{
		shopPanel.SetActive(true);
	}

	public void clicOnCloseShopBtn()
	{
		shopPanel.SetActive (false);
	}

	public void passiveBonusBtn()
	{
		passiveBonus++;
	}

	public void clickBonusBtn()
	{
		clickBonus++;
	}
}
