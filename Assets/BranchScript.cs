﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchScript : MonoBehaviour
{
    // Start is called before the first aya  frame update
    void Start()
    {
    	Debug.Log("start");
        Debug.Log("do smth in code");
    }

	
	void FixedUpdate()
	{
		transform.position += transform.forward * Time.fixedDeltaTime;
		tranform.Rotate(0,10,0);
	}
	
	void AddedAFuncPrev()
	{
		nada();
	}

    // Update is called once per frame
    void Update()
    {
        // a comment to specify what is to do in update
		Debug.Log("un log");
		// trerte
		float x = 10;
		
		MyThingy();
		for(int i=0; i < 10; i++)
		{
			// Things happening in loop();
		}
		
		EndUpdate();
    }
	
	void MyThingy()
	{
		Debug.Log("Waiting for game design docs to implement feature");
	}
	
	void EndUpdate()
	{
		//DoSomething();
	}
	
	void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere(transform.position, 10);
	}
	
	void OnTriggerEnter()
	{
	}
}
