using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterLinearSI : MonoBehaviour
{
    public GameObject LSISlopeValue;
    public GameObject LSIYIntValue;
    public LineRenderer linePrefab;
    public LineRenderer newLine;

    public void initializeEquation()
    {
        string slopeString = LSISlopeValue.GetComponent<Text>().text;
        string yInterceptString = LSIYIntValue.GetComponent<Text>().text;
        float slope = float.Parse(slopeString);
        float yIntercept = float.Parse(yInterceptString);
        drawLine(slope, yIntercept);
    }
    public void drawLine(float m, float b)
    {
        Destroy(newLine);
        newLine = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        newLine.SetPosition(0, new Vector3(-500, m*(-500)+b, 0));
        newLine.SetPosition(1, new Vector3(500, m*500+b, 0));
    }
}
