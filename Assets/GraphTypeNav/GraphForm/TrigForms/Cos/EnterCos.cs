using System;
using UnityEngine;
using UnityEngine.UI;


public class EnterCos : MonoBehaviour
{
    public GameObject CosAValue;
    public GameObject CosBValue;
    public GameObject CosCValue;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = CosAValue.GetComponent<Text>().text;
    	string BString = CosBValue.GetComponent<Text>().text;
    	string CString = CosCValue.GetComponent<Text>().text;
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
    		newLine.SetPosition(k, new Vector3(i, (float)(a * Math.Cos(i - b * Math.PI) + c), 0));
    		k++;
            Debug.Log(k);
    	}
    }
}
