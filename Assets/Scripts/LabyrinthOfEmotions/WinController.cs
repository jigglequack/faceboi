﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class WinController : MonoBehaviour 
{
	public GameObject winPanel;
	public Text winPanelText;
	public Text currentTimeText;
	public Text winTimeText;

	GameObject [] winObj;

	void Start() {
		if (winObj == null) {
			winObj = GameObject.FindGameObjectsWithTag ("ShowOnEnd");
		}

		//InvokeRepeating("changeWallColors", 1f, 1f);
	}

	void OnTriggerEnter() {
		Debug.Log ("OnTrigger");
		EventController.Instance.Publish (new GameOverEvent("random"));
		showEnd ();
	}


	void OnCollisionEnter(Collision collisionInfo)
	{
		Debug.Log ("OnCollision");
		EventController.Instance.Publish (new GameOverEvent("random"));
		showEnd ();
		//winPanel.SetActive (true);
		//winTimeText.text = "Time to complete: " + currentTimeText.text;
	}

	public void showEnd(){
		/*foreach(GameObject g in winObj){
			g.SetActive(true);
		}*/
		winPanelText.text = "You Win!!";
		winPanel.SetActive(true);
		winPanel.transform.SetAsLastSibling ();
	}

}