using UnityEngine;

public class count : MonoBehaviour
{
    public static float atai;
    public static float purasu;
    public GameObject puratxt;
    public Transform canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        atai=0;
        purasu=1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            OnClick();
        }
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            purasu+=1;
        }
    }
        public void OnClick()
    {
        Instantiate(puratxt, new Vector3( 693.0f, 334.0f, 0.0f), Quaternion.identity,canvas);
        atai+=purasu;
        Debug.Log(atai);  // ログを出力
    }
}

