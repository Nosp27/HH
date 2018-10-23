using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float z = transform.position.z;
            Vector3 newpos = Camera.main.ScreenToWorldPoint(touch.position);
            newpos.z = z;
            transform.position = newpos;
        }
	}
}
