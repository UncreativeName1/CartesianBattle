using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterQuarticFactored : MonoBehaviour
{
    public GameObject QuFactoredAValue;
    public GameObject QuFactoredR1Value;
    public GameObject QuFactoredR2Value;
    public GameObject QuFactoredR3Value;
    public GameObject QuFactoredR4Value;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = QuFactoredAValue.GetComponent<Text>().text;
    	string R1String = QuFactoredR1Value.GetComponent<Text>().text;
    	string R2String = QuFactoredR2Value.GetComponent<Text>().text;
    	string R3String = QuFactoredR3Value.GetComponent<Text>().text;
    	string R4String = QuFactoredR4Value.GetComponent<Text>().text;
    	float AValue = float.Parse(AString);
    	float R1Value = float.Parse(R1String);
    	float R2Value = float.Parse(R2String);
    	float R3Value = float.Parse(R3String);
    	float R4Value = float.Parse(R4String);
    	drawLine(AValue, R1Value, R2Value, R3Value, R4Value);
    }

    public void drawLine(float a, float b, float c, float d, float e) {
    	Destroy(newLine);
    	newLine = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        int k = 0;
        for (float i = -20f; i <= 20f; i += 0.1f) {
    		newLine.SetPosition(k, new Vector3(i, a*(i-b)*(i-c)*(i-d)*(i-e), 0));
    		k++;
    	}
    }
}