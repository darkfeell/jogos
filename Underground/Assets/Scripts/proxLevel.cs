using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class proxLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // (ticket.ins.ticketQuantity == 3)
        //{
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
