
using UnityEngine;

public class chick : MonoBehaviour
{
    #region 定義

    [Header("移動速度"), Range(1.0f, 100.0f)]
    public float Speed = 20;
    [Header("跳躍高度"),Range(1, 2000)]
    public int Jump = 200;
    [Header("對話內容")]
    public string Talk = "咕咕咕~~~";
    [Header("是否取得雞蛋")]
    public bool Egg;
    #endregion

    private void Start()
    {
        print("遊戲開始!!!");

    }

    private void Update()
    {
        print("咕咕咕~~~");
    }

}
