using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour {
    Renderer m_ObjectRenderer;

    // Use this for initialization
    void Start () {
        m_ObjectRenderer = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {

    }
    public void ShowElement()
    {
        m_ObjectRenderer.enabled = true;
    }
}
