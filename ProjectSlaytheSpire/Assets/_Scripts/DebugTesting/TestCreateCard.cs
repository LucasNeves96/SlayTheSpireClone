using UnityEngine;
using UnityEngine.InputSystem;

public class TestCreateCard : MonoBehaviour
{
    [SerializeField] private HandView hand;

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            CardVisual cardVisual = CardCreator.instance.CreateCardVisual(Vector3.zero, Quaternion.identity);
            StartCoroutine(hand.AddCard(cardVisual));
        }
    }
}
