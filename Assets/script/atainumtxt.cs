using UnityEngine;
using TMPro;
public class atainumtxt : MonoBehaviour
{
    public TextMeshProUGUI atainum;
    float a;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {   
        a=count.atai;
        atainum.text=""+a;
    }
}
