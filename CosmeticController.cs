using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticController : MonoBehaviour
{

    [SerializeField]
    private Player m_player;

    [SerializeField]
    private GameObject[] hats;

    [SerializeField]
    private GameObject[] faces;

    private int currentHat, currentFace;

    // Start is called before the first frame update
    void Start()
    {
        DisableAllCosmetics();
        currentHat = currentFace = -1;
    }

    public void EnableHat(int index) {

        //if the index is invalid, do nothing essentially and break out
        if (index < 0 && index >= hats.Length)
            return;

        //currentHat exists
        if (currentHat >= 0 && currentHat < hats.Length) {
            hats[currentHat].SetActive(false);
        }

        //check if the hat is a Mask - if so, disable the current face (if one is enabled)
        if (hats[index].CompareTag("Mask")) {
            DisableCurrentFace();
        }

        //enable the hat/mask, save it's index
        hats[index].SetActive(true);
        currentHat = index;

        
    }

    public void EnableFace(int index)
    {

        //if the index is invalid, do nothing essentially and break out
        if (index < 0 && index >= faces.Length)
            return;

        //currentFace exists
        if (currentFace >= 0 && currentFace < faces.Length)
        {
            faces[currentFace].SetActive(false);
        }

        //remove masks
        DisableCurrentHat();

        //enable the face, save it's index
        faces[index].SetActive(true);
        currentFace = index;

    }

    void DisableCurrentHat() {
        if (currentHat > 0 && currentHat < hats.Length) {
            if (hats[currentHat].CompareTag("Mask")) {
                hats[currentHat].SetActive(false);
                currentHat = -1;
            }
        }
    }

    void DisableCurrentFace() {
        if (currentFace > 0 && currentFace < faces.Length)
        {
            faces[currentFace].SetActive(false);
            currentFace = -1;
        }
    }


    void DisableAllCosmetics() {
        foreach (GameObject go in hats) {
            go.SetActive(false);
        }

        foreach (GameObject go in faces)
        {
            go.SetActive(false);
        }
    }

    public GameObject[] GetHatList() {
        return hats;
    }

    public GameObject[] GetFaceList()
    {
        return faces;
    }
}
