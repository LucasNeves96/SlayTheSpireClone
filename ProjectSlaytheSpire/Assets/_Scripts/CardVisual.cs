using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class CardVisual : MonoBehaviour
{
    [SerializeField] private SpriteRenderer Image;
    [SerializeField] private TMP_Text ManaValue;
    [SerializeField] private TMP_Text Title;
    [SerializeField] private TMP_Text Description;
    [SerializeField] private GameObject Wrapper;

    public Card card { get; private set; }

    public void Setup(Card card)
    {
        this.card = card;
        Title.text = card.Title;
        ManaValue.text = card.Mana.ToString();
        Description.text = card.Description;
        Image.sprite = card.Image;
    }
}
