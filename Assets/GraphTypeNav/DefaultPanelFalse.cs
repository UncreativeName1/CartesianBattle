using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultPanelFalse : MonoBehaviour
{
	public GameObject LinearFormsPanel;
	public GameObject QuadraticFormsPanel;
	public GameObject CubicFormsPanel;
	public GameObject QuarticFormsPanel;
	public GameObject RationalFormsPanel;
	public GameObject TrigPanel;
	public GameObject PolynomialPanel;
    // Start is called before the first frame update
    void Start()
    {
        LinearFormsPanel.SetActive(false);
        QuadraticFormsPanel.SetActive(false);
        CubicFormsPanel.SetActive(false);
        QuarticFormsPanel.SetActive(false);
        RationalFormsPanel.SetActive(false);
        TrigPanel.SetActive(false);
        PolynomialPanel.SetActive(false);
    }
}
