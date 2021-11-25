using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterQuadraticFactored : MonoBehaviour
{
    public GameObject QFactoredAValue;
    public GameObject QFactoredR1Value;
    public GameObject QFactoredR2Value;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = QFactoredAValue.GetComponent<Text>().text;
    	string R1String = QFactoredR1Value.GetComponent<Text>().text;
    	string R2String = QFactoredR2Value.GetComponent<Text>().text;
    	float AValue = float.Parse(AString);
    	float R1Value = float.Parse(R1String);
    	float R2Value = float.Parse(R2String);
    	drawLine(AValue, R1Value, R2Value);
    }

    public void drawLine(float a, float b, float c) {
    	Destroy(newLine);
    	newLine = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        int k = 0;
        for (float i = -20f; i <= 20f; i += 0.1f) {
    		newLine.SetPosition(k, new Vector3(i, a*(i-b)*(i-c), 0));
    		k++;
    	}
    }
}

