using UnityEngine;

public class StopMovP1 : MonoBehaviour
{
    public void Oncliclk()
    {
        Rigidbody2D rbP1 = GetComponent<Rigidbody2D>();
        rbP1.constraints = RigidbodyConstraints2D.FreezePosition;
    }
}
