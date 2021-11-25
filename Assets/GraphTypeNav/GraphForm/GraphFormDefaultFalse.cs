using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphFormDefaultFalse : MonoBehaviour
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

    void allPanelsFalse() {
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

    void Start()
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

}
