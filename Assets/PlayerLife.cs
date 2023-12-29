using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody rb;
    private CharacterController characterController;
    public GameObject DeadPanel;
    public GameObject MainPanel;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Die();
        }
    }

    private void Die()
    {
        Time.timeScale = 0;
        GetComponent<Controller>().enabled = false;
        GetComponent<SuperHotScript>().enabled = false;
        MainPanel.SetActive(false);
        DeadPanel.SetActive(true);
        Debug.Log("You Are DEAD");
    }
}
