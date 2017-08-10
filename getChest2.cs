using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getChest2 : MonoBehaviour {

	GameObject myTextgameObject;
	Text ourComponent;

	bool canDestroy = false;

	public Text countText;
	public int count;

	// Use this for initialization
	void Start () {
		myTextgameObject = GameObject.Find ("chestText");
		ourComponent = myTextgameObject.GetComponent<Text>();
		ourComponent.text = "Chests Found:";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E) && canDestroy == true) {
			Destroy (gameObject);
			count = count + 1;
			//ourComponent.text = "Chests Found:" + " " + count;
		}
		ourComponent.text = "Chests Found:" + " " + count;
	}


	void OnTriggerEnter (Collider other){
		canDestroy = true;
	}

	void OnTriggerExit (Collider other){
		canDestroy = false;
	}


	//void OnTriggerEnter (Collider other)
	//{
	//	if (other.tag == "Player" && Input.GetKey(KeyCode.E)) {
	//		Destroy (gameObject);
	//		count = count + 1;
	//		ourComponent.text = "Chests Found:" + " " + count;
	//	}
	//}

}
