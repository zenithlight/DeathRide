using UnityEngine;
using System.Collections;

public class BillboardFacing : MonoBehaviour {
	private Camera m_Camera;
	private string letter;
	private float timer;

	// Use this for initialization
	void Start () {
	  m_Camera = Camera.main;

		float random = Random.value;

		if (random < 0.25) {
			letter = "0";
			GetComponent<TextMesh>().text = "A";
		} else if (random < 0.5) {
			letter = "1";
			GetComponent<TextMesh>().text = "B";
		} else if (random < 0.75) {
			letter = "2";
			GetComponent<TextMesh>().text = "X";
		} else {
			letter = "3";
			GetComponent<TextMesh>().text = "Y";
		}

	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
			m_Camera.transform.rotation * Vector3.up);

		timer += Time.deltaTime;
		if (timer > 7) {
			Destroy (gameObject);
		}

		if (Input.GetButton (letter)) {
			Destroy (gameObject);
			GameObject.Find("/Cartoon_SportCar_B01").GetComponent<CarController>().torque -= 85;
		}
				}
}
