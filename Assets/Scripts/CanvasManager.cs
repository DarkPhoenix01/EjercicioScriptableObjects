using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;

    
    public Text text1Canvas;
    public Text text2Canvas;
    public Text text3Canvas;
    public Text text4Canvas;

    private void Awake() {
        if(Instance == null)
        {
            Instance = this;
            
        }else
        {
            Destroy(this);
        }
    }

    public void Addtranslate(TranslateText item) {
        {  
            
            text1Canvas.text = item.text1;
            text2Canvas.text = item.text2;
            text3Canvas.text = item.text3;
            text4Canvas.text = item.text4;
        }
    }

    void Start()
    {
        
    }

}
