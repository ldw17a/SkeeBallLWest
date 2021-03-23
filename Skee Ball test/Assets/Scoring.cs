using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public int points;
	public int Total;
	
	void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Ball")
		{
			Total += points;
		}
	}		
}
