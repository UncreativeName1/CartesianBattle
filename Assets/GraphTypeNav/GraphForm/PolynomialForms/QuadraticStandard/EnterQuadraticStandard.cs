using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterQuadraticStandard : MonoBehaviour
{
    public GameObject QStandardAValue;
    public GameObject QStandardBValue;
    public GameObject QStandardCValue;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = QStandardAValue.GetComponent<Text>().text;
    	string BString = QStandardBValue.GetComponent<Text>().text;
    	string CString = QStandardCValue.GetComponent<Text>().text;
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
    		newLine.SetPosition(k, new Vector3(i, a*i*i + b*i + c, 0));
    		k++;
            Debug.Log(k);
    	}
    }
}
