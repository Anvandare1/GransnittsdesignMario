using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
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
    public void ChangeScore(int antalcoin)
    {
        score+= antalcoin;


        text.text=score.ToString();
        
    }

   
}
