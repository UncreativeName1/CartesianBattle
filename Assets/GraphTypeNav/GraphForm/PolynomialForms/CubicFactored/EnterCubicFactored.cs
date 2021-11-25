using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterCubicFactored : MonoBehaviour
{
    public GameObject CFactoredAValue;
    public GameObject CFactoredR1Value;
    public GameObject CFactoredR2Value;
    public GameObject CFactoredR3Value;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = CFactoredAValue.GetComponent<Text>().text;
    	string R1String = CFactoredR1Value.GetComponent<Text>().text;
    	string R2String = CFactoredR2Value.GetComponent<Text>().text;
    	string R3String = CFactoredR3Value.GetComponent<Text>().text;
    	float AValue = float.Parse(AString);
    	float R1Value = float.Parse(R1String);
    	float R2Value = float.Parse(R2String);
    	float R3Value = float.Parse(R3String);
    	drawLine(AValue, R1Value, R2Value, R3Value);
    }

    public void drawLine(float a, float b, float c, float d) {
    	Destroy(newLine);
    	newLine = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        int k = 0;
        for (float i = -20f; i <= 20f; i += 0.1f) {
    		newLine.SetPosition(k, new Vector3(i, a*(i-b)*(i-c)*(i-d), 0));
    		k++;
    	}
    }
}
