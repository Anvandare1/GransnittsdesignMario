using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinManager : MonoBehaviour
{

    public static CoinManager instance;
    public TextMeshProUGUI text;
    int score;

    
    void Start()
    {
        if(instance==null)
        {
            instance= this;
        }
    }
    public void ChangeScore(int coinvalue)
    {

        score+= coinvalue;
        text.text="X"+score.ToString();
    }

   
}
