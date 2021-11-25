using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterQuarticStandard : MonoBehaviour
{
    public GameObject QuStandardAValue;
    public GameObject QuStandardBValue;
    public GameObject QuStandardCValue;
    public GameObject QuStandardDValue;
    public GameObject QuStandardEValue;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = QuStandardAValue.GetComponent<Text>().text;
    	string BString = QuStandardBValue.GetComponent<Text>().text;
    	string CString = QuStandardCValue.GetComponent<Text>().text;
    	string DString = QuStandardDValue.GetComponent<Text>().text;
    	string EString = QuStandardEValue.GetComponent<Text>().text;
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
    		newLine.SetPosition(k, new Vector3(i, a*i*i*i*i + b*i*i*i + c*i*i + d*i + e, 0));
    		k++;
    	}
    }
}
