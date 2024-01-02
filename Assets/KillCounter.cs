using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    int kill;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showKill();
    }

    private void showKill()
    {
        counterText.text = kill.ToString();
    }
    public void addKill()
    {
        kill++;
    }
}
