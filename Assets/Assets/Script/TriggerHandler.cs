using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandler : MonoBehaviour {

	public LayerMask RespondTo = ~0; 

	public GameObjectEvent TriggerEnter;
	public GameObjectEvent TriggerStay;
	public GameObjectEvent TriggerLeave;

	bool ShouldRespond(GameObject g)
	{
		return ((RespondTo & (1 << g.layer)) != 0);
	}

	void OnTriggerEnter(Collider c)
	{
		if (ShouldRespond(c.gameObject))
		{
			TriggerEnter.Invoke(c.gameObject);
		}
	}

	void OnTriggerStay(Collider c)
	{
		if (ShouldRespond(c.gameObject))
		{
			TriggerStay.Invoke(c.gameObject);
		}
	}

	void OnTriggerLeave(Collider c)
	{
		if (ShouldRespond(c.gameObject))
		{
			TriggerLeave.Invoke(c.gameObject);
		}
	}
}
