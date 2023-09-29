using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IABasica : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent agent;

	public GameObject target;
/*	void Awake(){

		agent = GetComponent<NavMeshAgent>();

		target = GameObject.FindGameObjectWithTag("Player");

//public NavMeshAgent navenemy;



		

	}*/

	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

		target = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		agent.destination=target.transform.position;

}
	
	
	
}