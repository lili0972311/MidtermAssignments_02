using UnityEngine;

namespace KUMO

{

    #region 事件區域

    /// <summary>
    /// 發射系統基底類別
    /// 生成子彈
    /// </summary>
    public class PlayerFireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject playerprefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform playerpointSpawn;


        protected void SpawnBullet()
        {

            Instantiate(playerprefabBullet, playerpointSpawn.position, playerpointSpawn.rotation);
        }
    }
#endregion
}

