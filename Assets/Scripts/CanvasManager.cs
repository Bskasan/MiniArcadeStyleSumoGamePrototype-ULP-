using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class CanvasManager : MonoBehaviour
{

    private SpawnManager spawnManager;
    public TextMeshProUGUI waveText;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        waveText.text = "Wave : " + spawnManager.waveNumber;
    }
}
