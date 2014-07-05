using UnityEngine;
using System.Collections;

public class ButtonOptions : MonoBehaviour {

	private bool showHouse = false;
	private bool houseBought = false;

	GUIContent[] comboBoxList;
	private ComboBox comboBoxControl = new ComboBox();
	private GUIStyle listStyle = new GUIStyle();

	// Use this for initialization
	void Start () {
		comboBoxList = new GUIContent[2];
		comboBoxList[0] = new GUIContent("Thing 1");
		comboBoxList[1] = new GUIContent("Thing 2");

		listStyle.normal.textColor = Color.white; 
		listStyle.onHover.background = null;
		listStyle.hover.background = new Texture2D(2, 2);
		listStyle.padding.left = 1;
		listStyle.padding.right = 1;
		listStyle.padding.top = 1;
		listStyle.padding.bottom = 4;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
//		int selectedItemIndex = comboBoxControl.GetSelectedItemIndex();
//	    selectedItemIndex = comboBoxControl.List( 
//		new Rect(50, 100, 100, 20), comboBoxList[selectedItemIndex].text, comboBoxList, listStyle );
//	    GUI.Label( new Rect(50, 70, 400, 21), "You picked " + comboBoxList[selectedItemIndex].text + "!" );

		if (showHouse) {
			if (GUI.Button(new Rect(50, 125, 130, 30), "Lowclass - House")) {
				GameManager.currencySys.updatePlyMoney(-500000);
				showHouse = false;
				houseBought = true;
				GameManager.clockSys.IsPause = false;
			}
			if (GUI.Button(new Rect(50, 150, 130, 30), "Midclass - House")) {
				GameManager.currencySys.updatePlyMoney(-500000);
				showHouse = false;
				houseBought = true;
				GameManager.clockSys.IsPause = false;
			}
			if (GUI.Button(new Rect(50, 175, 130, 30), "Highclass - House")) {
				GameManager.currencySys.updatePlyMoney(-5000000);
				showHouse = false;
				houseBought = true;
				GameManager.clockSys.IsPause = false;
			}
			if (GUI.Button(new Rect(50, 200, 130, 30), "Cancel")) {
				showHouse = false;
				GameManager.clockSys.IsPause = false;
			}
		} else if(!houseBought) {
			if (GUI.Button(new Rect(1, 150, 100, 30), "Buy House")) {
				showHouse = true;
				GameManager.clockSys.IsPause = true;
				Debug.Log("Show House Menu");
			}
		}

	}
}
