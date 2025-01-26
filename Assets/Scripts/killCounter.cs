using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class killCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    int kills;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showKills();
    }
    private void showKills()
    {
        counterText.text = kills.ToString();
    }

    public void addKill()
    {
        print("addKill");
        kills++;
    }
}
