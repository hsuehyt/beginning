using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    public string firstName; // Existing public variable for the first name.
    public string lastName;  // Added public variable for the last name.

    private TextMeshProUGUI textMeshPro; // Private variable to hold the TextMeshProUGUI component.

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>(); // Get the TextMeshProUGUI component.
        // Update the text to include both the first name and last name.
        textMeshPro.text = $"Hello {firstName} {lastName}!";
    }

    // Update is called once per frame
    void Update()
    {
        // This method is left empty as before.
    }
}
