using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plussSpawners : MonoBehaviour {

	public GameObject plus;
//	public Vector3 spawnValues;

	public void plusSpawner()
	{
		Vector3 spawnPosition = new Vector3 (0,0,0);
		Instantiate (plus, spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation); 
	}
}
