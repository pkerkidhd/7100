using UnityEngine;
using System.Collections;

public class CurrencySystem : MonoBehaviour {

	private float _plyMoney = 221000000.00f;
	public GUIText moneyTxt;

	// Use this for initialization
	void Start () {
		moneyTxt.text = "Money: $" + _plyMoney.ToString("n2") + " CAD";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updatePlyMoney(float value) {
		_plyMoney += value;
		moneyTxt.text = "Money: $" + _plyMoney.ToString("n2") + " CAD";
	}

}
