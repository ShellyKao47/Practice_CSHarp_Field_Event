
using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("速度"), Range(1.5f, 500f)]
    public float speed = 10.5f;
    [Header("跳躍高度"), Range(10, 100)]
    public int Jump = 50;
    [Header("對話內容")]
    public string Taik = "咕咕咕~~~";
    [Header("是否取得雞蛋")]
    public bool Egg = false;
    
    // Start is called before the first frame update
    void Start()
    {
        print("遊戲開始!!");

    }

    // Update is called once per frame
    void Update()
    {
        print("咕咕咕~");

    }
}
