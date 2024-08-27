using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeCenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Zera o contador de itens colocados
        SlotItenDrop.itensColocados = 0;

        // Zera o total de itens (opcional, se você quiser redefinir o total)
        SlotItenDrop.totalItens = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
