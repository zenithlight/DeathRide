#pragma strict

var rearViewMirror = Vector3(-0.244, 1.213, -0.04);
var steeringWheel = Vector3(-0.308, 1.155, -0.04);
var leftWindow = Vector3(-0.65, 1.23, -0.06);
var rightWindow = Vector3(0.68, 7.301, -0.07);
var behind = Vector3(0, 1.2, -1.01);

var timer = 0.0;

var cubePrefab : Transform;

function Start () {
}

function Update () {
	timer += Time.deltaTime;

	if (timer > 3) {
		timer -= 3;
		addEvent();
	}
}

function addEvent() {
	 var cube = Instantiate(cubePrefab, Vector3(0, 0, 0), Quaternion.identity);
	 cube.transform.parent = gameObject.transform;
	 Destroy(cube.GetComponent(BoxCollider));

	 var random = Random.value;

	 if (random < 0.2) {
	 	 	cube.transform.localPosition = rearViewMirror;
	 	 	cube.transform.localScale = Vector3(0.008, 0.008, 0.008);
	 }
	 else if (random < 0.4) {
	 	 	cube.transform.localPosition = steeringWheel;
	 	 	cube.transform.localScale = Vector3(0.008, 0.008, 0.008);
	 }
	 else if (random < 0.6) {
	 	 	cube.transform.localPosition = leftWindow;
	 	 	cube.transform.localScale = Vector3(0.05, 0.05, 0.05);
	 }
	 else if (random < 0.8) {
	 	    cube.transform.localPosition = rightWindow;
	 	    cube.transform.localScale = Vector3(0.05, 0.05, 0.05);
	 }
	 else {
	        cube.transform.localPosition = behind;
	        cube.transform.localScale = Vector3(0.05, 0.05, 0.05);
	 }
}