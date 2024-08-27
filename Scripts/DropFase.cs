using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour
{
    public int id; // Adicione o campo id � classe Item
}


    public class DropFase : MonoBehaviour
{

    public GameObject[] itens; // Array para armazenar os objetos dos itens
    public Transform[] locaisCorretos; // Array para armazenar os locais corretos para cada item
    public GameObject avisoErro; // Objeto do aviso de erro (pode ser um texto na tela)
    public int itensColocados = 0; // Contador de itens colocados corretamente
    public int totalItens = 3; // N�mero total de itens

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se todos os itens foram colocados corretamente
        if (itensColocados == totalItens)
        {
            // Passa para a pr�xima fase
            // Exemplo: Carrega a pr�xima cena
        }
    }


    public void VerificarItem(GameObject item)
    {
        // Encontra o local correto para o item
        for (int i = 0; i < locaisCorretos.Length; i++)
        {
            if (locaisCorretos[i].childCount == 0 && item.GetComponent<Item>().id == i)
            {
                // Item est� no local correto
                item.transform.SetParent(locaisCorretos[i]);
                itensColocados++;
                avisoErro.SetActive(false); // Desativa o aviso de erro
                return;
            }
        }

        // Item est� no local errado
        avisoErro.SetActive(true); // Ativa o aviso de erro

    }

}
