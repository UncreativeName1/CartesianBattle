using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolynomialOptions : MonoBehaviour
{
    public GameObject LinearFormsPanel;
    public GameObject QuadraticFormsPanel;
    public GameObject CubicFormsPanel;
    public GameObject QuarticFormsPanel;

    public void GraphTypeLinear () 
    {
    	if (LinearFormsPanel.activeSelf == true) 
    	{
    		LinearFormsPanel.SetActive(false);
    		QuadraticFormsPanel.SetActive(false);
    		CubicFormsPanel.SetActive(false);
    		QuarticFormsPanel.SetActive(false);
    	} else 
    	{
    		LinearFormsPanel.SetActive(true);
    		QuadraticFormsPanel.SetActive(false);
    		CubicFormsPanel.SetActive(false);
    		QuarticFormsPanel.SetActive(false);
    	}
    }

    public void GraphTypeQuadratic () 
    {
    	if (QuadraticFormsPanel.activeSelf == true) 
    	{
    		LinearFormsPanel.SetActive(false);
    		QuadraticFormsPanel.SetActive(false);
    		CubicFormsPanel.SetActive(false);
    		QuarticFormsPanel.SetActive(false);
    	} else 
    	{
    		LinearFormsPanel.SetActive(false);
    		QuadraticFormsPanel.SetActive(true);
    		CubicFormsPanel.SetActive(false);
    		QuarticFormsPanel.SetActive(false);
    	}
    }

    public void GraphTypeCubic () 
    {
    	if (CubicFormsPanel.activeSelf == true) 
    	{
    		LinearFormsPanel.SetActive(false);
    		QuadraticFormsPanel.SetActive(false);
    		CubicFormsPanel.SetActive(false);
    		QuarticFormsPanel.SetActive(false);
		} else 
		{
			LinearFormsPanel.SetActive(false);
    		QuadraticFormsPanel.SetActive(false);
    		CubicFormsPanel.SetActive(true);
    		QuarticFormsPanel.SetActive(false);
		}
    }

    public void GraphTypeQuartic () 
    {
    	if (QuarticFormsPanel.activeSelf == true) 
    	{
    		LinearFormsPanel.SetActive(false);
    		QuadraticFormsPanel.SetActive(false);
    		CubicFormsPanel.SetActive(false);
    		QuarticFormsPanel.SetActive(false);
		} else 
		{
			LinearFormsPanel.SetActive(false);
    		QuadraticFormsPanel.SetActive(false);
    		CubicFormsPanel.SetActive(false);
    		QuarticFormsPanel.SetActive(true);
		}
    }
}






