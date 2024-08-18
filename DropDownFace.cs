using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * DropDownFace generates list of cosmetic options/names for available face cosmetics stored in CosmeticController
 * Sends selected cosmetic to cosmeticController wherein cosmeticController enables selected face cosmetic.
 */

public class DropDownFace : MonoBehaviour
{
    public CosmeticController cosmeticController;
    private TMP_Dropdown m_dropdown;

    // Start is called before the first frame update
    void Start()
    {
        m_dropdown = GetComponent<TMP_Dropdown>();

        //populate list based on hat lsit
        m_dropdown.ClearOptions();

        List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();

        foreach (GameObject go in cosmeticController.GetFaceList())
        {
            TMP_Dropdown.OptionData newOption = new TMP_Dropdown.OptionData();

            newOption.text = go.name;

            options.Add(newOption);
        }

        TMP_Dropdown.OptionData lastOption = new TMP_Dropdown.OptionData();

        lastOption.text = "Select Face";

        options.Add(lastOption);

        m_dropdown.AddOptions(options);

        m_dropdown.value = m_dropdown.options.Count;
    }

    public void ChangeFace()
    {
        if (m_dropdown.value == m_dropdown.options.ToArray().Length - 1)
            return;

        cosmeticController.EnableFace(m_dropdown.value);

        m_dropdown.value = m_dropdown.options.Count; //sets it to the SelectHat text

        m_dropdown.RefreshShownValue();
        //m_dropdown.value = -1;
    }
}
