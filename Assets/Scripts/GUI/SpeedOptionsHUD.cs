using UnityEngine;
using System.Collections;

public class SpeedOptionsHUD : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button(new Rect(0, 125, 130, 30), "Lowclass - House")) {
			GameManager.currencySys.updatePlyMoney(-500000);
			showHouse = false;
			houseBought = true;
			GameManager.clockSys.IsPause = false;
		}
	}
}
