using UnityEngine;
using UnityEngine.InputSystem;

public class TestCreateCard : MonoBehaviour
{
    [SerializeField] private HandView hand;
    [SerializeField] private CardData cardData;

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Card cardToCreate = new Card(cardData);
            CardVisual cardVisual = CardCreator.instance.CreateCardVisual(cardToCreate, Vector3.zero, Quaternion.identity);
            StartCoroutine(hand.AddCard(cardVisual));
        }
    }
}
