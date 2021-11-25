using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterLinearStandard : MonoBehaviour
{
    public GameObject LStandardAValue;
    public GameObject LStandardBValue;
    public GameObject LStandardCValue;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = LStandardAValue.GetComponent<Text>().text;
    	string BString = LStandardBValue.GetComponent<Text>().text;
    	string CString = LStandardCValue.GetComponent<Text>().text;
    	float AValue = float.Parse(AString);
    	float BValue = float.Parse(BString);
    	float CValue = float.Parse(CString);
    	drawLine(AValue, BValue, CValue);
    }

    public void drawLine(float a, float b, float c) {
    	Destroy(newLine);
    	newLine = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    	newLine.SetPosition(0, new Vector3(-500, (-a/b)*(-500)-(c/b), 0));
    	newLine.SetPosition(1, new Vector3(500, (-a/b)*(500)-(c/b), 0));
    }
}

