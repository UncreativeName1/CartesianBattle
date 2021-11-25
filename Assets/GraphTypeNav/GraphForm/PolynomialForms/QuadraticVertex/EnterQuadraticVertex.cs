using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterQuadraticVertex : MonoBehaviour
{
    public GameObject QVertexAValue;
    public GameObject QVertexHValue;
    public GameObject QVertexKValue;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation() {
    	string AString = QVertexAValue.GetComponent<Text>().text;
    	string HString = QVertexHValue.GetComponent<Text>().text;
    	string KString = QVertexKValue.GetComponent<Text>().text;
    	float AValue = float.Parse(AString);
    	float HValue = float.Parse(HString);
    	float KValue = float.Parse(KString);
    	drawLine(AValue, HValue, KValue);
    }

    public void drawLine(float a, float b, float c) {
    	Destroy(newLine);
    	newLine = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        int k = 0;
        for (float i = -20f; i <= 20f; i += 0.1f) {
    		newLine.SetPosition(k, new Vector3(i, a*(i-b)*(i-b) + c, 0));
    		k++;
    	}
    }
}