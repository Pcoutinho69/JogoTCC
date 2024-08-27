using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class item : MonoBehaviour
{
    public int id; // ID do item (corresponde ao local correto)

    void OnMouseDown()
    {
        // Ao clicar no item, chama a função VerificarItem no FaseManager
        GetComponent<DropFase>().VerificarItem(gameObject);
    }
}
