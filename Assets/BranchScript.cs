﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchScript : MonoBehaviour
{
    // Start is called before the first aya  frame update
    void Start()
    {
        Debug.Log("do smth in code");
        Debug.Log("other log");
		// comment
    }

    // Update is called once per frame
    void Update()
    {
        // a comment to specify what is to do in update
		Debug.Log("un log");
    }
	
	void OnTriggerEnter()
	{
		Destroy(gameObject);
	}
}
