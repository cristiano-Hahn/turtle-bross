﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Cam : MonoBehaviour {
	private Transform mario;


	void Start () {
		Screen.SetResolution(256, 240, true, 60);
		mario = GameObject.Find("Mario").transform;
	}
	
	void Update () {
	
			transform.position =  new Vector3(mario.position.x, transform.position.y, -10);
	
	}
}
