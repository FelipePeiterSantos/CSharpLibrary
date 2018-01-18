using UnityEngine;
using System.Collections;

public class buttonEvent : MonoBehaviour {

	public GameObject Panel;

	public void click(){
		Panel.SendMessage (this.gameObject.name);
	}
}
