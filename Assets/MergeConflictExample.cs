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
<<<<<<< HEAD
		float b = x * 1.5f;
		
		MyThingy();
		For(int i=0;i++)
		{
			Things happening in loop();
		}
=======
>>>>>>> 4b5e834997494d94b5caa4f4e683553504e996bf
    }
	
	void FuncA()
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
