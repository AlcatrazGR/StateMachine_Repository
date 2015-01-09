﻿using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;

public class GameData : MonoBehaviour {

	public Texture2D beginStateSplash;
	public Texture2D lostStateSplash;
	public Texture2D wonStateSplash;
	public List<GameObject> cameras;

	[HideInInspector]
	public int playerLives;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}