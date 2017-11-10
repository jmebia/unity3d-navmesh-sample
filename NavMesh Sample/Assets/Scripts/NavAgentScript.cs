using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentScript : MonoBehaviour {

    public GameObject targetObject;
    public GameObject wall;

    private NavMeshAgent agent;

    private float startTime;

    private bool isFloating;



	// Use this for initialization
	void Start () {

        agent = this.GetComponent<NavMeshAgent>();

        agent.SetDestination(targetObject.transform.position);

        startTime = Time.deltaTime;

        isFloating = false;

	}
	
	// Update is called once per frame
	void Update () {



    }
}



