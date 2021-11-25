using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterCubicStandard : MonoBehaviour
{
    public GameObject CStandardAValue;
    public GameObject CStandardBValue;
    public GameObject CStandardCValue;
    public GameObject CStandardDValue;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = CStandardAValue.GetComponent<Text>().text;
    	string BString = CStandardBValue.GetComponent<Text>().text;
    	string CString = CStandardCValue.GetComponent<Text>().text;
    	string DString = CStandardDValue.GetComponent<Text>().text;
    	float AValue = float.Parse(AString);
    	float BValue = float.Parse(BString);
    	float CValue = float.Parse(CString);
    	float DValue = float.Parse(DString);
    	drawLine(AValue, BValue, CValue, DValue);
    }

    public void drawLine(float a, float b, float c, float d) {
    	Destroy(newLine);
    	newLine = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        int k = 0;
        for (float i = -20f; i <= 20f; i += 0.1f) {
    		newLine.SetPosition(k, new Vector3(i, a*i*i*i + b*i*i + c*i + d, 0));
    		k++;
    	}
    }
}
