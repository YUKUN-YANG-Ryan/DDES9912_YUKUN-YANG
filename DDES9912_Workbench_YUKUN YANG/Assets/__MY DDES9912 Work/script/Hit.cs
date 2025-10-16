using UnityEngine;

public class LaunchObject : MonoBehaviour
{
    public Rigidbody rb;          // 物体的刚体
    public float force = 500f;    // 击飞的力量大小
    public Vector3 direction = Vector3.forward; // 击飞方向（默认向上）

    void Start()
    {
        // 自动获取刚体组件
        if (rb == null)
            rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 按下空格键时执行击飞
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
    }

    void Launch()
    {
        // 清除当前速度，防止力叠加
        rb.linearVelocity = Vector3.zero;

        // 给物体施加一个瞬时冲力（Impulse）
        rb.AddForce(direction.normalized * force, ForceMode.Impulse);

        Debug.Log("TREMENDOUS WIND!!!");
    }
}