using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GridGenerator : MonoBehaviour
{
    public GameObject horizontalGridLine;
    public GameObject verticalGridLine;
    public GameObject xAxis;
    public GameObject yAxis;
    //public Text axisLabel;

    // Start is called before the first frame update
    void Start()
    {
        //axisLabel = gameObject.GetComponent<Text>();
        setHorizontalGridLine();
        setVerticalGridLine();
        setXAxis();
        setYAxis();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void setHorizontalGridLine()
    {
        for (int i=-500; i<=500; i++)
        {
            Instantiate(horizontalGridLine, new Vector3(-500, i, 90), Quaternion.identity);
        }
    }
    void setVerticalGridLine()
    {
        for (int i=-500; i<=500; i++)
        {
            Instantiate(verticalGridLine, new Vector3(i, -500, 90), Quaternion.identity); 
        }
    }
    void setXAxis()
    {
        Instantiate(xAxis, new Vector3(-500, 0, 90), Quaternion.identity);
    }
    void setYAxis()
    {
        Instantiate(yAxis, new Vector3(0, -500, 90), Quaternion.identity);
        /*for (int i = -500; i <= 500; i++)
        {
            axisLabel.text = "ywa";
            Instantiate(axisLabel, new Vector3(0.5, i+0.5, 1), Quaternion.identity);
        }*/
    }
}
