using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
//using objectSize;


public class PlayerController : MonoBehaviour {

	public Text countText;
	public Text timeText;
	public Text highscoreText;
	int nextSceneIndex;
	public float speed;
	private Rigidbody2D rgd2;
	bool a;
	//int b;
	private int Meme_Count;
	float boundsSum = 6;
	int highscore;

	public float currentTime = 60f;

	float timeStart;
	float timeEnd;
	TimeSpan ts;


	void Start(){
		rgd2 = GetComponent<Rigidbody2D> ();
		Meme_Count = 0;
		SetCountText ();
		timeStart = Time.time;
		SetTimeText ();
		highscore = 0;
		SetHighscore ();
	}
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rgd2.AddForce (movement*speed);

		timeEnd = Time.time;
		SetTimeText ();
		if (Meme_Count== 50) {
			//Game is over, change to next
			nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
			if (SceneManager.sceneCount > nextSceneIndex)
			{
				SceneManager.LoadScene(nextSceneIndex);
			}
		}
		currentTime += Time.deltaTime;
		//ts = TimeSpan.FromSeconds(60);//(long)(timeEnd - timeStart));
		//timeEnd - timeStart;
		//float sec = timeEnd - timeStart;
		//ts = TimeSpan(timeEnd - timeStart);
		//double sec = ts.Seconds;
		//print(ts.Seconds);
		float cTime = currentTime;
		TimeSpan timeSpan = TimeSpan.FromSeconds(cTime);

		double ts = timeSpan.Seconds; 
		if (currentTime == 10) {
			highscore = Meme_Count;
			SetHighscore ();
		}
		else if(currentTime>10){
			SetHighscore ();
		}

	}

	/*void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Pickup")){
			//other.gameObject.transform.parent = rgd2.transform;
			//transform.localPosition = rgd2
			other.gameObject.SetActive(false); //adding other. makes the other object disappear
		}
	}*/

	void OnCollisionEnter2D(Collision2D hit)
	{
		//Debug.LogError("memberVariable must be set to point to a Transform.", transform);
		//hit.gameObject.
		//hit.transform.position+=transform.forward*Time.deltaTime*speed;

		/*if (other.gameObject.CompareTag("Pickup")){
			other.gameObject1.transform.parent = gameObject2.transform; //adding other. makes the other object disappear
		//
		*/

		//a = hit.gameObject.CompareTag ("Background");
		//if (a !=true)
		//{

		//b+= GetSize.hit
		/*gameObject.Size() += hit.gameObject.objectSize();

		if (gameObject.Size () < hit.gameObject.objectSize ()) {
			throw Exception ("YOU LOST");
		} else {*/
		print(hit.collider.bounds.size.x + hit.collider.bounds.size.y);
		if (hit.collider.bounds.size.x + hit.collider.bounds.size.y < boundsSum)
		{
			boundsSum += hit.collider.bounds.size.x + hit.collider.bounds.size.y;

			Meme_Count += 1;
			hit.gameObject.transform.parent = gameObject.transform;
			//hit.gameObject.objectSize.getId() + 1; //HERE
			//}

		}

		//hit.gameObject.objectSize.getId() + 1; //HERE
		SetCountText();
		//}



		//}

		/*foreach (ContactPoint contact in hit.contacts) {
			FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
			fixedJoint.anchor = contact.point;
			fixedJoint.connectedBody = hit.rigidbody;
		}*/
	}
	void SetCountText(){
		countText.text = "Meme Collected:" + Meme_Count.ToString ();
	}
	void SetTimeText(){
		timeText.text = "Time Passed:" + (timeEnd-timeStart).ToString ();
	}
	void SetHighscore(){
		highscoreText.text = "HIGH SCORE:" + highscore.ToString ();
	}

	//USELESS
	/*void EnableRagdoll(){
		rgd2.isKinematic = false;
		rgd2.detectCollision = true;

	}
	void DisableRagdoll(){
		rgd2.isKinematic = true;
		rgd2.collisionDetectionMode = false;

	}*/
}
