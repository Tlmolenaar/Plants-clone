﻿using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	
	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad (gameObject);
		
	}
	
	void Start(){
		audioSource = GetComponent<AudioSource>();
	}
	// Update is called once per frame
	void OnLevelWasLoaded(int level){
		Debug.Log("Loaded level" + levelMusicChangeArray[level]);
		AudioClip levelMusic = levelMusicChangeArray[level];
		
		if(levelMusic){
			audioSource.clip = levelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
}
