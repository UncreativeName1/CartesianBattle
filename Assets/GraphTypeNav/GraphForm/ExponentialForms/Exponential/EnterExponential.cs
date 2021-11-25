using System;
using UnityEngine;
using UnityEngine.UI;

public class EnterExponential : MonoBehaviour
{
    public GameObject ExpStandardAValue;
    public GameObject ExpStandardBValue;
    public GameObject ExpStandardCValue;
    public GameObject ExpStandardDValue;
    public GameObject ExpStandardEValue;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = ExpStandardAValue.GetComponent<Text>().text;
    	string BString = ExpStandardBValue.GetComponent<Text>().text;
    	string CString = ExpStandardCValue.GetComponent<Text>().text;
    	string DString = ExpStandardDValue.GetComponent<Text>().text;
    	string EString = ExpStandardEValue.GetComponent<Text>().text;
    	float AValue = float.Parse(AString);
    	float BValue = float.Parse(BString);
    	float CValue = float.Parse(CString);
    	float DValue = float.Parse(DString);
    	float EValue = float.Parse(EString);
    	drawLine(AValue, BValue, CValue, DValue, EValue);
    }

    public void drawLine(float a, float b, float c, float d, float e) {
    	Destroy(newLine);
    	newLine = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        int k = 0;
        for (float i = -20f; i <= 20f; i += 0.1f) {
    		newLine.SetPosition(k, new Vector3(i, a * (float)Math.Pow( (double)b, (double)(c * (i - d) ) ) + e, 0));
    		k++;
    	}
    }
}

