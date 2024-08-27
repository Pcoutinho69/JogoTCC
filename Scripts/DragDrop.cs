using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public TipoLixo tipoLixo;
    public LixoType lixoType;
    public TypeLixo typeLixo;
    public string lixo;
    public RectTransform rectTransform;

    [SerializeField] private Canvas canvas;
    [SerializeField] private CanvasGroup canvasGroup;


    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown (PointerEventData eventData)
    {
        Debug.Log("mouse precionou o objeto");
    }  


    public void OnBeginDrag (PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData evenData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag (PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta/ canvas.scaleFactor;
    }
}
