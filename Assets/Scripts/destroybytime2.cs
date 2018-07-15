using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybytime2 : MonoBehaviour {

    public float lifetime;

	void Start () {
        Destroy(gameObject, lifetime);
	}
	
	
}
