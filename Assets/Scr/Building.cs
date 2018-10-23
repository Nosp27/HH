using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightenObject : MonoBehaviour {

    [SerializeField] Sprite daySprite;
    [SerializeField] Sprite nightSprite;

	// Use this for initialization
	void Start () {
        GameManager gm = FindObjectOfType<GameManager>();
        gm.DaytimeChanged += ChangeDaytime;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChangeDaytime(Daytime dt)
    {
        if(daySprite != null || nightSprite != null)
        GetComponent<SpriteRenderer>().sprite = dt == Daytime.Day ? daySprite : nightSprite;
    }
}
