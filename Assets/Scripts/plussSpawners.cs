using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plussSpawners : MonoBehaviour {
	public GameObject Canvas;
	public GameObject plus;
//	public Vector3 spawnValues;
	//пока хз
	public void plusSpawner()
	{
		StartCoroutine (instDest());
	}	
	IEnumerator instDest()
	{
		Vector3 spawnPosition = new Vector3 (0,0,0);
		plus = Instantiate (plus, spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation) as GameObject;
		plus.transform.SetParent (Canvas.transform, false);
		yield return new WaitForSeconds (2);
		Destroy (plus);
	}
}
