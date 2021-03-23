using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturn : MonoBehaviour
{
	public GameObject Chute;
	public GameObject Ball;
	
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Hole") 
		{
			Ball.transform.position = Chute.transform.position;
		}
	}
}
