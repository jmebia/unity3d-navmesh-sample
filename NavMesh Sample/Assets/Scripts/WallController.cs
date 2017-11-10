using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour {

    private bool isFloating;

	// Use this for initialization
	void Start () {
        isFloating = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && !isFloating)
        {
            isFloating = !isFloating;
            this.transform.Translate(0, 3, 0);
        }
    }
}
