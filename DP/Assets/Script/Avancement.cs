using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avancement : MonoBehaviour {

	public static Avancement instance;
	private Slider slider;
	void Start () {
		instance = this;
		slider = this.GetComponent<Slider> ();

	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Camera.main.transform.position.x;
	}

	public void SetLeftObjective(GameObject leftie){
		slider.minValue = leftie.transform.position.x;
	}

	public void SetRightObjective(GameObject rightie){
		slider.maxValue = rightie.transform.position.x;
	}
		
}
