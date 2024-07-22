using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text FruitsText;

    private int fruits = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruits"))
        {
            Destroy(collision.gameObject);
            fruits++;
            FruitsText.text = "fruits: " + fruits;
        }
    }
}
