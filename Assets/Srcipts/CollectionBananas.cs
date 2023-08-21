using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectionBananas : MonoBehaviour
{
    private int bananas = 0;

    [SerializeField] private TextMeshProUGUI bananasText;

    [SerializeField] private AudioSource bananasSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Banana"))
        {
            bananasSoundEffect.Play();
            Destroy(collision.gameObject);
            bananas++;
            bananasText.text = "Bananas: " + bananas;
        }
    }
}
