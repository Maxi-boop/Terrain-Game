using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresed : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public int num; 

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseUpAsButton()
    {
        int myInt = int.Parse(text.text);
        num += 1;
        myInt = num; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
