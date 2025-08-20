using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

public class HandView : MonoBehaviour
{
    [SerializeField] private SplineContainer splineContainer;
    private readonly List<CardVisual> cards = new List<CardVisual>();

    public IEnumerator AddCard(CardVisual cardVisual)
    {
        cards.Add(cardVisual);
        yield return UpdatePositions(0.15f);
    }

    private IEnumerator UpdatePositions(float duration)
    {
        if (cards.Count == 0) yield break;
        float cardSpacing = 1f / 10f;
        float firstCardPosition = 0.5f - (cards.Count - 1) * cardSpacing / 2;
        Spline spline = splineContainer.Spline;

        for (int i = 0; i < cards.Count; i++)
        {
            float p = firstCardPosition + i * cardSpacing;
            
            Vector3 splinePosition = spline.EvaluatePosition(p);
            Vector3 forward = spline.EvaluateTangent(p);
            Vector3 up = spline.EvaluateUpVector(p);
            Quaternion rotation = quaternion.LookRotation(-up, Vector3.Cross(-up, forward).normalized);
            cards[i].transform.DOMove(splinePosition + transform.position + 0.01f * i * Vector3.back, duration);
            cards[i].transform.DORotate(rotation.eulerAngles, duration);
        }
        
        yield return new WaitForSeconds(duration);
    }

}
