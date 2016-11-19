using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {
public float torque = 300;
	private float score = 0;

	void Start() {
		gameObject.GetComponent<Rigidbody>().centerOfMass = new Vector3 (0, -0.3F, 0);
	}

	 void Update ()
	{
		WheelCollider frontLeft = transform.Find ("Tires").Find ("Tire_Front_L").gameObject.GetComponent<WheelCollider> ();
		WheelCollider frontRight = transform.Find ("Tires").Find ("Tire_Front_R").gameObject.GetComponent<WheelCollider> ();
		WheelCollider backLeft = transform.Find ("Tires").Find ("Tire_Back_L").gameObject.GetComponent<WheelCollider> ();
		WheelCollider backRight = transform.Find ("Tires").Find ("Tire_Back_R").gameObject.GetComponent<WheelCollider> ();

		frontLeft.steerAngle = 20 * Input.GetAxis("x axis");
		frontRight.steerAngle = 20 * Input.GetAxis("x axis");

		backLeft.motorTorque = torque;
		backRight.motorTorque = torque;

		torque += Time.deltaTime * 25;
		score += Time.deltaTime;
		if (transform.eulerAngles.z > 170 && transform.eulerAngles.z < 190) {
			PlayerPrefs.SetFloat ("score", score);
			Application.LoadLevel ("Score");
		}
	}
}