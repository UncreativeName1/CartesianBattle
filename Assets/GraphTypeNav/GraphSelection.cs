using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphSelection : MonoBehaviour
{
    public GameObject PolynomialSubpanel;
    public GameObject TrigonometrySubpanel;

    public GameObject RationalFormsPanel;

    public GameObject LinearFormsPanel;
    public GameObject QuadraticFormsPanel;
    public GameObject CubicFormsPanel;
    public GameObject QuarticFormsPanel;
    // dont need game object for exponential or circle since they directly open up the graphing menu

    public void AllSelectionPanelsFalse() 
    {
        PolynomialSubpanel.SetActive(false);
        TrigonometrySubpanel.SetActive(false);
        RationalFormsPanel.SetActive(false);
        LinearFormsPanel.SetActive(false);
        QuadraticFormsPanel.SetActive(false);
        CubicFormsPanel.SetActive(false);
        QuarticFormsPanel.SetActive(false);
    }


    public void GraphTypePolynomial()
    {
        if (PolynomialSubpanel.activeSelf == true)
        {
            AllSelectionPanelsFalse();
        } else
        {
            AllSelectionPanelsFalse();
            PolynomialSubpanel.SetActive(true);
        }
    }
    public void GraphTypeTrigonometry()
    {
        if (TrigonometrySubpanel.activeSelf == true)
        {
            AllSelectionPanelsFalse();
        } else
        {
            AllSelectionPanelsFalse();
            TrigonometrySubpanel.SetActive(true);
        }
    }

    public void GraphTypeRational ()
    {
        if (RationalFormsPanel.activeSelf == true) 
        {
            AllSelectionPanelsFalse();
        } else
        {
            AllSelectionPanelsFalse();
            RationalFormsPanel.SetActive(true);
        }
    }
}
