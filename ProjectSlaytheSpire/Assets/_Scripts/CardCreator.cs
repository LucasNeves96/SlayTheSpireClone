using DG.Tweening;
using UnityEngine;

public class CardCreator : MonoBehaviour
{
    #region Singleton

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    public static CardCreator instance { get; private set; }

    #endregion

    [SerializeField] private CardVisual cardVisualPrefab;

    public int test = 0;

    public CardVisual CreateCardVisual(Vector3 position, Quaternion quaternion)
    {
        CardVisual cardVisual = Instantiate(cardVisualPrefab, position, quaternion);
        cardVisual.transform.localScale = Vector3.zero;
        cardVisual.transform.DOScale(Vector3.one, 0.15f);

        return cardVisual;
    } 

}
