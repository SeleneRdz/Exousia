using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//************** agregar para mover botones y texto
using TMPro; // ********* Esto para crear objetos tipo TextMeshPro


public class KarmaManager : MonoBehaviour
{
    [SerializeField]
    private Scr_KarmaBar karmaBar;
    #pragma warning restore 0649

    bool bandera = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        moreKarma();
    }


    public void moreKarma()
    {
        if(bandera == false){
            karmaBar.moreKarma(20f);
        }
        bandera = true;
    }

}
