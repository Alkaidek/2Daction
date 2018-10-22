using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartController : MonoBehaviour {
    Renderer m_ObjectRenderer;

    // Use this for initialization
    void Start()
    {
        m_ObjectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void HideElement(string tag)
    {
        if(transform.tag == tag)
        {
            m_ObjectRenderer.enabled = false;
        }
    
    }
}
