using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreInteractable : MonoBehaviour
{
    public GameObject TiendaUI;
    private bool show = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(show)
        {
            TiendaUI.SetActive(true);
        }
        else
        {
            TiendaUI.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                show = !show;
            }
        }
    }

    void OnTriggerExit2D()
    {
        show = false;
    }

}
