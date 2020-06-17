using UnityEngine;
using System.Collections;

public class AddButtons : MonoBehaviour {

    [SerializeField]
    private Transform memoryField;

    [SerializeField]
    private GameObject btn;

    

    void Awake()
    {
        for (int i = 0; i < 8; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(memoryField,false);
        }

    }
	
	}

