using UnityEngine;

namespace KUMO
{

    #region 事件區域

    ///<summary>
    ///敵機發射
    /// </summary>

    public class EnermyFireSystem : EnermyFireSystemBase
    {
        [SerializeField, Header("生成間隔"), Range(0, 5)]
        private float interval = 2;
        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, interval);
        }

    }
    #endregion

}
