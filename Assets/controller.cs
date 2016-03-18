using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void Movement (){
		float speed = 1.9F;
		float xtranslation = Input.GetAxis("Horizontal") * speed;
		float ytranslation = Input.GetAxis("Vertical") * speed;

		xtranslation *= Time.deltaTime;
		ytranslation *= Time.deltaTime;


		transform.Translate(xtranslation,ytranslation,0);
        

	}

	// Update is called once per frame
	void Update () {
		Movement();
	}
}
