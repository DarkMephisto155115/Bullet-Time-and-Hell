using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMouseSensitivity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setMouseSensitivity(float val)
    {
        PlayerPrefs.SetFloat("Sensitivity", val);
        Debug.Log("set sensitivity to" + val);
    }
}
