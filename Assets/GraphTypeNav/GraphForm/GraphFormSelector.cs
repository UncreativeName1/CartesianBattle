using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphFormSelector : MonoBehaviour
{
    public GameObject LinearStandardPanel;
    public GameObject LinearSIPanel;
    public GameObject QuadraticStandardPanel;
    public GameObject QuadraticFactoredPanel;
    public GameObject QuadraticVertexPanel;
    public GameObject CubicStandardPanel;
    public GameObject CubicFactoredPanel;
    public GameObject QuarticStandardPanel;
    public GameObject QuarticFactoredPanel;
    public GameObject SinPanel;
    public GameObject CosPanel;
    public GameObject TanPanel;
    public GameObject CscPanel;
    public GameObject SecPanel;
    public GameObject CotPanel;
    public GameObject RationalStandardPanel;
    public GameObject RationalFactoredPanel;
    public GameObject ExponentialPanel;
    public GameObject CirclePanel;

    public void AllPanelFalse()
    {
        LinearStandardPanel.SetActive(false);
        LinearSIPanel.SetActive(false);
        QuadraticStandardPanel.SetActive(false);
        QuadraticVertexPanel.SetActive(false);
        QuadraticFactoredPanel.SetActive(false);
        CubicStandardPanel.SetActive(false);
        CubicFactoredPanel.SetActive(false);
        QuarticStandardPanel.SetActive(false);
        QuarticFactoredPanel.SetActive(false);
        SinPanel.SetActive(false);
        CosPanel.SetActive(false);
        TanPanel.SetActive(false);
        CscPanel.SetActive(false);
        SecPanel.SetActive(false);
        CotPanel.SetActive(false);
        RationalStandardPanel.SetActive(false);
        RationalFactoredPanel.SetActive(false);
        ExponentialPanel.SetActive(false);
        CirclePanel.SetActive(false);
    }

    public void OpenLinearStandard()
    {
    	AllPanelFalse();
        LinearStandardPanel.SetActive(true);
    }
    public void OpenLinearSI()
    {
    	AllPanelFalse();
        LinearSIPanel.SetActive(true);
    }
    public void OpenQuadraticStandard()
    {
    	AllPanelFalse();
        QuadraticStandardPanel.SetActive(true);
    }
    public void OpenQuadraticFactored()
    {
    	AllPanelFalse();
        QuadraticFactoredPanel.SetActive(true);
    }
    public void OpenQuadraticVertex()
    {
    	AllPanelFalse();
        QuadraticVertexPanel.SetActive(true);
    }
    public void OpenCubicStandard()
    {
    	AllPanelFalse();
        CubicStandardPanel.SetActive(true);
    }
    public void OpenCubicFactored()
    {
    	AllPanelFalse();
        CubicFactoredPanel.SetActive(true);
    }
    public void OpenQuarticStandard()
    {
    	AllPanelFalse();
        QuarticStandardPanel.SetActive(true);
    }
    public void OpenQuarticFactored()
    {
    	AllPanelFalse();
        QuarticFactoredPanel.SetActive(true);
    }
    public void OpenSin()
    {
    	AllPanelFalse();
        SinPanel.SetActive(true);
    }
    public void OpenCos()
    {
    	AllPanelFalse();
        CosPanel.SetActive(true);
    }
    public void OpenTan()
    {
    	AllPanelFalse();
        TanPanel.SetActive(true);
    }
    public void OpenSec()
    {
    	AllPanelFalse();
        SecPanel.SetActive(true);
    }
    public void OpenCsc()
    {
    	AllPanelFalse();
        CscPanel.SetActive(true);
    }
    public void OpenCot()
    {
    	AllPanelFalse();
        CotPanel.SetActive(true);
    }
    public void OpenRationalStandard()
    {
    	AllPanelFalse();
        RationalStandardPanel.SetActive(true);
    }
    public void OpenRationalFactored()
    {
    	AllPanelFalse();
        RationalFactoredPanel.SetActive(true);
    }
    public void OpenExponential()
    {
    	AllPanelFalse();
       	ExponentialPanel.SetActive(true);
    }
    public void OpenCircle()
    {
    	AllPanelFalse();
        CirclePanel.SetActive(true);
    }

}









