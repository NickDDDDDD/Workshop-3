// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class XAxisSpin : MonoBehaviour
{
    public enum CubeType {I, A, B, C, D }
    public CubeType cubeType;
    private Vector3 initPosA = new Vector3(2.0f, 0.0f, 0.0f);
    [SerializeField] private float spinSpeed;
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float moveRange = 3.0f;

    // Update() is called once *per frame*. It is called *after* the Start()
    // method, which is only called once when the component is enabled for the
    // first time. You'll find that the execution order of these lifecycle
    // methods matters, and this can be fairly nuanced when components reference
    // each other, and/or if you are enabling and disabling components at
    // runtime.
    //
    // Recommended reading:
    // - https://docs.unity3d.com/Manual/ExecutionOrder.html
    private void Update()
    {
        

        switch (cubeType)
        {
            case CubeType.I:
                SpinInXAxis();
                break;
            case CubeType.A:
                MoveInZAxis();
                break;    
        }
    }


    private void SpinInXAxis()
    {
        var angle = this.spinSpeed * Time.time;
        var axis = new Vector3(1.0f, 0.0f, 0.0f);
        
        transform.localRotation = Quaternion.AngleAxis(angle, axis);
    }

    private void MoveInZAxis(){

       float zPosition = Mathf.Sin(Time.time * moveSpeed) * moveRange;
       transform.position = new Vector3(initPosA.x, initPosA.y, zPosition);
    }
}
