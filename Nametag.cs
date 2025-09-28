using UnityEngine;

public class Nametag : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Nombre: " + gameObject.name + ", Tag: " + tag.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
