using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{

    public void  OpenChannel()
    {
        Application.OpenURL("https://github.com/Rahavy/challenge");
    }
    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
