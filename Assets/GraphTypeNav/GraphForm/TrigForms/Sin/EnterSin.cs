using System;
using UnityEngine;
using UnityEngine.UI;


public class EnterSin : MonoBehaviour
{
    public GameObject SinAValue;
    public GameObject SinBValue;
    public GameObject SinCValue;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = SinAValue.GetComponent<Text>().text;
    	string BString = SinBValue.GetComponent<Text>().text;
    	string CString = SinCValue.GetComponent<Text>().text;
    	float AValue = float.Parse(AString);
    	float BValue = float.Parse(BString);
    	float CValue = float.Parse(CString);
    	drawLine(AValue, BValue, CValue);
    }

    public void drawLine(float a, float b, float c) {
    	Destroy(newLine);
    	newLine = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        int k = 0;
        for (float i = -20f; i <= 20f; i += 0.1f) {
    		newLine.SetPosition(k, new Vector3(i, (float)(a * Math.Sin(i - b * Math.PI) + c), 0));
    		k++;
            Debug.Log(k);
    	}
    }
}
