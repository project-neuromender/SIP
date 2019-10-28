using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtFollow : MonoBehaviour
{
    public Transform mTarget;

    float mSpeed = 1.0f;
    Vector2 mLookDirection;

    const float EPSILON = 0.07f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mLookDirection = (mTarget.position - transform.position).normalized;

        if((transform.position - mTarget.position).magnitude > EPSILON)
        transform.Translate(mLookDirection * Time.deltaTime * mSpeed);
    }
}
