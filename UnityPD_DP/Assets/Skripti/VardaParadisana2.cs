using UnityEngine;
using System.Collections;
//Jāpievieno namespace, lai varētu lietot UI elementus.
using UnityEngine.UI;

public class VardaParadisana2 : MonoBehaviour {
    // Update is called once per frame
    void Update () {
        //Ja grib tekstu, kas parādās jau rakstīšanas brīdī, tad kodu no uzglabatTekstu liek te.
    }

    //Teksts ko rakstīs
    public string teksts;
    //Lauks kurā ierakstīs tekstu
    public GameObject ievadesLauks;
    //Kur attēlos tekstu
    public GameObject tekstaAttelosana;

    public void uzglabaTekstu(){
        //No komponentes IevadesLauks1 iegūst pakārtoto Text komponenti
        teksts = ievadesLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Tev ir: "+teksts.ToUpper()+" gadi!";
    }
}  
