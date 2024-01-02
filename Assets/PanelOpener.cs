using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{

    
    // Start is called before the first frame update
    public GameObject panel;
    public GameObject b1;
    public GameObject b2;
    public void openPanel()
    {
        if (panel != null)
        {
            b1.SetActive(false);
            b2.SetActive(false);
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void closePanel()
    {
        if (panel != null)
        {
            b1.SetActive(true);
            b2.SetActive(true);
            panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
