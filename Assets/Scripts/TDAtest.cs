using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDAtest : MonoBehaviour
{
    bool flagEscala = false;
    //array
    public GameObject[] cubos = new GameObject [3];
    int[] escalas = new int [3] {2,3,4};

    //Lista
    List<string> nombres = new List<string>();

    //Cola
    Queue apellidos = new Queue();

    void Start()
    {
        nombres.Add("Nico");
        nombres.Add("Pedro");
        apellidos.Enqueue("Sosa");
        apellidos.Enqueue("Varela");
    }

    void Update()
    {
        //++++++++++++++  Uso del array ++++++++++++

        if(Input.GetKeyDown(KeyCode.Z) && (flagEscala == false))
        {
            flagEscala = true;
            for(int i = 0 ; i < cubos.Length ; i++)
            {
                cubos[i].transform.localScale = cubos[i].transform.localScale * escalas[i];
            }
        }   

        if(Input.GetKeyDown(KeyCode.X) && (flagEscala == true))
        {
            flagEscala = false;
            for(int i = cubos.Length - 1 ; i >= 0  ; i--)
            {
                cubos[i].transform.localScale = cubos[i].transform.localScale / escalas[i];
            }
        }

        //++++++++++++++  Uso del listas ++++++++++++

        if(Input.GetKeyDown(KeyCode.C))
        {
            nombres.Add("Persona");
            Debug.Log("En la lista hay " + nombres.Count + " personas");
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            if(nombres.Count > 0)
            {
                nombres.RemoveAt(0);
                Debug.Log("Se removio una persona. En la lista hay " + nombres.Count + " personas");
            }
            else Debug.Log("No hay elementos de la lista que puedan removerse");
                        
        }

        //++++++++++++++  Uso del colas ++++++++++++ 

        if(Input.GetKeyDown(KeyCode.B))
        {
                apellidos.Enqueue("Roca");
                Debug.Log("Se agrega a la cola el apellido Roca");
        }

        if(Input.GetKeyDown(KeyCode.N))
        {
            if(apellidos.Count > 0)
            {
                Debug.Log("Se retira el apellido " + apellidos.Dequeue() + " de la cola");                
            }
            else Debug.Log("No hay elementos de la cola que puedan removerse");
            
        }               
    }
}
