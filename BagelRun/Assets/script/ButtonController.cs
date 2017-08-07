﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

	public GameObject bagel, run;
	private float currentRemainTime;
	private SpriteRenderer spRenderer;
	public float fadeTime = 1f;
	private AudioSource sound01, sound02;

	// Use this for initialization
	void Start () {
		sound01 = GetComponent<AudioSource>();
		sound02 = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnClick() { // MUST public
		PlayerPrefs.SetInt("StartButton", 1);
		bagel.gameObject.SetActive (false);
		run.gameObject.SetActive (false);
		sound01.PlayOneShot(sound01.clip);
		print ("clicked");
	}

	public void TapStart() {
		Application.LoadLevel ("mainScene");
	}

	public void TapOption() {
		sound01.PlayOneShot(sound02.clip);
		Application.LoadLevel ("OptionScene");
		print("Option");
	}

	public void Restart(){
		Application.LoadLevel ("mainScene");
	}
	public void BackHome(){
		Application.LoadLevel ("startScene");
	}
	public void gameStart(){
		Application.LoadLevel ("mainScene");
	}
}
