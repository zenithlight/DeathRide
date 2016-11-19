#pragma strict

function Start () {
	transform.Find("aa").gameObject.GetComponent(TextMesh).text = PlayerPrefs.GetInt("score").ToString();;
}

function Update () {
	if (Input.GetButton("0")) {
		Application.LoadLevel("Untitled");
	}
}