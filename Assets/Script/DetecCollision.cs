using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecCollision : MonoBehaviour
{
	void OnTriggerEnter(Collider manzana)
	{
		Destroy(gameObject);
		Destroy(manzana.gameObject);
	}
}
