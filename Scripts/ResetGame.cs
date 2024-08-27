using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ResetGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Redefina o contador quando a cena for carregada
        SlotItenDrop.itensColocados = 0;
        Fase25.itensColocados = 0;
        Fase35.itensColocados = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        // Redefina o contador quando a cena for carregada
        SlotItenDrop.itensColocados = 0;
    }
}
