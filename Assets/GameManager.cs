using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Scrollbar rotX;
	public Scrollbar rotY;
	public Scrollbar rotZ;
	public Text rotText;

	public Transform cube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		cube.rotation = Quaternion.Euler (360*rotX.value, 360*rotY.value, 360*rotZ.value);
		rotText.text = "X: " + 360*rotX.value + "\nY: " +  360*rotY.value + "\nZ: " +  360*rotZ.value;
	}
}
