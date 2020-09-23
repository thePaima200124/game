using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string result;
    public int points;
    //public float size;
    public Color color;

    Renderer _renderer;

    [ContextMenu("Update the albedo color")]
    public void UpdateColor()
    {
        _renderer.material.color = color;
    }

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        UpdateColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        
    }
}
