using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class killCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    int kills;

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
