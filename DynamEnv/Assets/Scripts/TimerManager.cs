﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour {


	private Camera mainCam;
	public float danceSeconds = 15f;

	// Use this for initialization
	void Start () {
		mainCam = Camera.main;
		Invoke ("cameraout", danceSeconds);
	}

	public void cameraout(){
		mainCam.GetComponent<Animator> ().SetTrigger ("cameraout");
		Invoke ("fadeout", 7f);
	}

	void fadeout(){
		StartCoroutine (GameObject.FindObjectOfType<SceneFader>().FadeAndLoadScene(SceneFader.FadeDirection.In,"ExportMenu"));
	}
}
