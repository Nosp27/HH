using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Daytime
{
    Day,
    Night
}

public class GameManager : MonoBehaviour {
    public Daytime DayTime = Daytime.Day;
    public event Action<Daytime> DaytimeChanged;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
