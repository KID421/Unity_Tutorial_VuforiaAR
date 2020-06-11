using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("要生成的敵人")]
    public GameObject enemy;
    [Header("要生成的位置")]
    public Transform[] points;
    [Header("一開始的間隔時間")]
    public float time = 2.5f;
    [Header("每次間隔減少時間")]
    public float timeSub = 0.05f;

    public void Spawn()
    {
        int r = Random.Range(0, points.Length);
        Instantiate(enemy, points[r]);

        Invoke("Spawn", time);
        time -= timeSub;
        time = Mathf.Clamp(time, 0.5f, 2.5f);
    }
}
