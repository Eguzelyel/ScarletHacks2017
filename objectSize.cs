using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSize : MonoBehaviour {

	//SIZE OF THE NUGGETS

	//public GameObject object;

	private int sizeInit = 0;
	//float timeStart;
	//float timeEnd;

	static int id=0;

	//float timePast;
	// Use this for initialization

	public void Start () {
		id+=1;
		//timeStart = Time.time;



		/*if(found){
			//set scale according to the time.
			object.transform.localScale *= new Vector3(1.2,1.2,1);
			sizeInit=object.transform.localScale;
			//make it visible
			gameObject.SetActive(false);
		}*/
		sizeInit = 10; //Some function that's been called from intializer
	}
	public int getId(){
		return id;
	}
	public void setId(int idd){
		id = idd;
	}

	public int getSizeInit(){
		return sizeInit;
	}
	public void setSizeInit(int sizeIn){
		sizeInit = sizeIn;
	}

	// Update is called once per frame
	void Update () {
		//NOTHING - AFTER COLLSISION WHAT HAPPENS
		/*if (gameObject.activeSelf == false){
			//timeEnd = Time.time;
			//timePast = timeEnd - timeStart;
			sizeInit +=  (float)(1.4f) * Time.deltaTime;
		}*/
	}
		
}
