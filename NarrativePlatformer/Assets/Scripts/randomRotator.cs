﻿using UnityEngine;
using System.Collections;

public class randomRotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.rotation = Random.rotation;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
