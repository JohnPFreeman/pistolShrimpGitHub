using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killCounter : MonoBehaviour
{
    public Text counterText;
    int kills;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void showKills()
    {
    }

    public void addKill()
    {
        kills++;
    }
}
