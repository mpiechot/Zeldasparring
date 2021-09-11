using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = (int)(1/Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
