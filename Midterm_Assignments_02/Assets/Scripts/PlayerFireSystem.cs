using UnityEngine;

namespace KUMO
{

    #region 事件區域

    ///<summary>
    ///玩家發射
    /// </summary>

    public class PlayerFireSystem : PlayerFireSystemBase
    {
        
        private void Update()
        {

            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }

        }

    }

    #endregion
}

