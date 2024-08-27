using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public enum TypeLixeira
{
    Papel,
    Plastico,
    Metal,
    Organico,
    Vidro
}

public enum TypeLixo
{
    Papel,
    Plastico,
    Metal,
    Organico,
    Vidro
}

public class Fase35 : MonoBehaviour, IDropHandler
{
    // Define o tipo da lixeira
    public TypeLixo typeLixeira;

    // Verifica se o lixo correto foi colocado na lixeira
    public bool lixoCorreto = false;

    public static int itensColocados = 0; // Contador de itens colocados corretamente
    public static int totalItens = 10; // Total de itens para serem colocados

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData != null)
        {
            GameObject lixo = eventData.pointerDrag.gameObject;
            DragDrop dragDrop = lixo.GetComponent<DragDrop>();

            // Verifica se o tipo do lixo corresponde ao tipo da lixeira
            if (dragDrop.typeLixo == typeLixeira)
            {
                // Se o lixo estiver correto, marca como colocado
                lixoCorreto = true;
                itensColocados++;
                Debug.Log("Lixo correto! Itens colocados: " + itensColocados);

                // Verifica se todos os lixos foram colocados corretamente
                if (itensColocados == totalItens)
                {
                    // Se todos os lixos foram colocados, o jogador ganhou
                    Debug.Log("Parabéns! Você venceu!");
                    // Carregue a próxima fase
                    SceneManager.LoadScene("Fim");
                }
            }
            else
            {
                // Se o lixo estiver errado, avisa ao jogador
                Debug.Log("Lixo errado!");
                lixoCorreto = false; // Limpa a flag de lixo correto
                SceneManager.LoadScene("CenaPerdeu 2");

            }

            // Reposiciona o lixo na posição original
            lixo.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
