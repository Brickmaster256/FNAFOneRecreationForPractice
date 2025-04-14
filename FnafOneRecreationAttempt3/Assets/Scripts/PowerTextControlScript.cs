using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]
public class PowerTextControlScript : MonoBehaviour
{
    private TextMeshProUGUI text;
    public PowerScriptableObject powerObj;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        UpdateWithIntData();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateWithIntData();  
    }

    public void UpdateWithIntData()
    {
        text.text = "Power: " + powerObj.power.ToString(CultureInfo.InvariantCulture) + "%"; 
    }

}
