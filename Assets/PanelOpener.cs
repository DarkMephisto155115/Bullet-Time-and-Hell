using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{

    
    // Start is called before the first frame update
    public GameObject panel;

    public void openPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void closePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
