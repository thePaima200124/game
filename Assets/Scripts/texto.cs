
using UnityEngine;
using TMPro;

public class texto : MonoBehaviour
{
    public TextMeshProUGUI municion;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        municion.text = Nave.inventario[Nave.expanzor];
    }
}
