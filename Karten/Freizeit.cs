using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Freizeit : MonoBehaviour, IDropHandler
{

    [SerializeField] GameObject[] ersch�pfungen;
    
    public void OnDrop(PointerEventData eventData)
    {
        
        GameObject droppedObject = eventData.pointerDrag.gameObject;
        DisplayKarten gedroppteKarte = droppedObject.GetComponent<DisplayKarten>();


        if (gedroppteKarte != null && transform.childCount == 0 && gedroppteKarte.npcData.profession != "Sonderkarte")
        {
           
            gedroppteKarte.parentbeforeDrag = transform;
            gedroppteKarte.transform.SetParent(transform);
           // gedroppteKarte.allowDrag = false;
            gedroppteKarte.npcData.ersch�pfung = 3;
            
            for(int i = 0; i < ersch�pfungen.Length; i++)
            {
                ersch�pfungen[i].GetComponent<Ersch�pfung>().CheckErsch�pfung();
            }
               

        }




        
    }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
