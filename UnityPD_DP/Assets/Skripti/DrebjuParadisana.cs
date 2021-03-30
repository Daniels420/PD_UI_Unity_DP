using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrebjuParadisana : MonoBehaviour {
    public GameObject CepuresIzvele;
    public GameObject BrunuIzvele;
    public GameObject KurpesIzveleK;
    public GameObject KurpesIzveleL;
    public GameObject ElkonaIzveleK;
    public GameObject ElkonaIzveleL;
    public GameObject PlecsK;
    public GameObject PlecsL;
    public GameObject Bikses;
    public GameObject IerociL;
    public GameObject IerociK;

    public void CepuresIzveleAttelosana(bool vertiba){
        CepuresIzvele.SetActive(vertiba);
    }
    public void BrunuIzveleAttelosana(bool vertiba){
        BrunuIzvele.SetActive(vertiba);
    }
    public void KurpesIzveleKAttelosana(bool vertiba){
        KurpesIzveleK.SetActive(vertiba);
    }
        public void KurpesIzveleLAttelosana(bool vertiba){
        KurpesIzveleL.SetActive(vertiba);
        }
        public void ElkonaIzveleKAttelosana(bool vertiba){
        ElkonaIzveleK.SetActive(vertiba);
        }
        public void ElkonaIzveleLAttelosana(bool vertiba){
        ElkonaIzveleL.SetActive(vertiba);
        }
        public void PlecsKAttelosana(bool vertiba){
        PlecsK.SetActive(vertiba);
        }
        public void PlecsLAttelosana(bool vertiba){
        PlecsL.SetActive(vertiba);
        }
        public void BiksesAttelosana(bool vertiba){
        Bikses.SetActive(vertiba);
        }
        public void IerociKAttelosana(bool vertiba){
        IerociK.SetActive(vertiba);
        }
        public void IerociLAttelosana(bool vertiba){
        IerociL.SetActive(vertiba);
        }

}

