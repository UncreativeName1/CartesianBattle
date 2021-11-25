using System;
using UnityEngine;
using UnityEngine.UI;


public class EnterTan : MonoBehaviour
{
    public GameObject TanAValue;
    public GameObject TanBValue;
    public GameObject TanCValue;
    public LineRenderer linePrefab;
    public LineRenderer[] newLine = new LineRenderer[13];


    public void initializeEquation() {
    	string AString = TanAValue.GetComponent<Text>().text;
    	string BString = TanBValue.GetComponent<Text>().text;
    	string CString = TanCValue.GetComponent<Text>().text;
    	float AValue = float.Parse(AString);
    	float BValue = float.Parse(BString);
    	float CValue = float.Parse(CString);
    	drawLine(AValue, BValue, CValue);
    }

    public void drawLine(float a, float b, float c) {
        float formula(float j) { 
            return (float)(a * (float)Math.Tan(j - b * Math.PI) + c);
        }

        int l = 0, k = 0;
        for (float i = -6.5f; i < 6.5f; i++) {

            newLine[l] = Instantiate(linePrefab, new Vector3(0, 0, 0), Quaternion.identity);

            for (float j = (float)Math.PI * i; j < (float)Math.PI * (i + 1f); j += 0.05f) {

                if (j >= -20 && j <= 20) {

                    newLine[l].SetPosition(k, new Vector3(j, formula(j), 0));
                    k++;
                    Debug.Log("l:" + l + ", k:" + k + ", Y-value:" + formula(i));


                }

            }
            k = 0;
            l++;
        }
    }
}
