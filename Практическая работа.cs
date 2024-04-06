using UnityEngine;

public class MovementWithAnimationCurve : MonoBehaviour
{
    public AnimationCurve movementCurve;

    private float elapsedTime = 0f;

    void Update()
    {        
        elapsedTime += Time.deltaTime;
        float curveValue = movementCurve.Evaluate(elapsedTime);
        transform.position = new Vector3(curveValue, 0f, 0f);

        float glowIntensity = movementCurve.Evaluate(elapsedTime);
        GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white * Mathf.LinearToGammaSpace(glowIntensity));
    }
}