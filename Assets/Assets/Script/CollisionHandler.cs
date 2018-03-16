using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class GameObjectEvent : UnityEvent<GameObject>
{
}

public class CollisionHandler : MonoBehaviour {

	public LayerMask RespondTo = ~0; 

	public GameObjectEvent CollisionEnter;
	public GameObjectEvent CollisionStay;
	public GameObjectEvent CollisionLeave;

	bool ShouldRespond(GameObject g)
	{
		return ((RespondTo & (1 << g.layer)) != 0);
	}

	void OnCollisionEnter(Collision c)
	{
		if (ShouldRespond(c.gameObject))
		{
			CollisionEnter.Invoke(c.collider.gameObject);
		}
	}

	void OnCollisionStay(Collision c)
	{
		if (ShouldRespond(c.gameObject))
		{
			CollisionStay.Invoke(c.collider.gameObject);
		}
	}

	void OnCollisionLeave(Collision c)
	{
		if (ShouldRespond(c.gameObject))
		{
			CollisionLeave.Invoke(c.collider.gameObject);
		}
	}
}
