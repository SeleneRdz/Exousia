using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scr_MagicBar : MonoBehaviour
{
    public Image magicBar;

    float magic, maxMagic = 100f;
    // Start is called before the first frame update
    void Start()
    {
        magic = maxMagic;
    }
   
    // Update is called once per frame
    public void useMagic(float amount)
    {
        magic = Mathf.Clamp(magic-amount, 0f, maxMagic);
        magicBar.transform.localScale = new Vector2(magic/maxMagic, 1);
    }
}
