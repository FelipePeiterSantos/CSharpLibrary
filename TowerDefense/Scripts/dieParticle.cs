using UnityEngine;
using System.Collections;

public class dieParticle : MonoBehaviour {
	
	void Start () {
		Invoke ("OnComplete", 0.5f);
	}

	public void OnComplete () {
		Destroy (this.gameObject);
	}
}
