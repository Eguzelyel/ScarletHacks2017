using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour {

	//FOR ONLY THE PLAYER

	private int sizeInit = 0;
	// Use this for initialization

	public void Start () {
		sizeInit = 10;
	}

	public int getSizeInit(){
		return sizeInit;
	}
	public void setSizeInit(int sizeIn){
		sizeInit = sizeIn;
	}

	// Update is called once per frame
	void Update () {
		//Refer to the colissions
	}


}
