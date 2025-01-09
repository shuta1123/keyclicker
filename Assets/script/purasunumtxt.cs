using UnityEngine;
using TMPro;
using System;
using System.Threading.Tasks;
using Unity.VisualScripting;

public class purasunumtxt : MonoBehaviour
{
    public TextMeshProUGUI purasunum;
    float a;
    double ti;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ti=Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        a=count.purasu;
        purasunum.text="+"+a;
        if(Time.time-1>=ti)
        Destroy(this.gameObject);

    }
}
