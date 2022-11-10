using UnityEngine;

namespace KUMO
{

    #region 事件區域

    /// <summary>
    /// 玩家控制器 2D 模式
    /// SerializeField 控制器顯示在Unity左方操作頁面
    /// </summary>
    public class PlayerControl : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 5;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 5;
        [Header("動畫預置物")]
        [SerializeField]
        private Sprite Jump;
        [SerializeField]
        private Sprite Middle;
        [SerializeField]
        private Sprite Down;

        [SerializeField, Header("圖片渲染元件")]
        private SpriteRenderer spr;


        private void Update()
        {
            
            float v = Input.GetAxis("Vertical");

            
            float h = Input.GetAxis("Horizontal");

            transform.Translate(speedHorizontal * Time.deltaTime * h,
            speedVertical * Time.deltaTime * v,
            0);

            
            if (v > 0)
            {
                print("往上");

                spr.sprite = Jump;
            }
            
            if (v < 0)
            {
                print("往下");

                spr.sprite = Down;
            }
           
            if (v == 0)
            {
                print("中間");

                spr.sprite = Middle;
            }
        }

    }
#endregion
}
