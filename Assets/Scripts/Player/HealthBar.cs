using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Image health;

    float hp, maxHp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
    }
   
    // Update is called once per frame
    public void TakeDamage(float amount)
    {
        hp = Mathf.Clamp(hp-amount, 0f, maxHp);
        health.transform.localScale = new Vector2(hp/maxHp, 1);
    }
}
