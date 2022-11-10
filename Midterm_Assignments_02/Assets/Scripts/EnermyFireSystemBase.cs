using UnityEngine;

namespace KUMO

{

    #region 事件區域


    /// <summary>
    /// 發射系統基底類別
    /// 生成子彈
    /// </summary>
    public class EnermyFireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("子彈生成點2")]
        private Transform pointSpawn2;
        [SerializeField, Header("子彈生成點3")]
        private Transform pointSpawn3;
        [SerializeField, Header("子彈生成點4")]
        private Transform pointSpawn4;



        protected void SpawnBullet()
        {
           
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
            Instantiate(prefabBullet, pointSpawn2.position, pointSpawn2.rotation);
            Instantiate(prefabBullet, pointSpawn3.position, pointSpawn3.rotation);
            Instantiate(prefabBullet, pointSpawn4.position, pointSpawn4.rotation);

        }
    }

    #endregion
}

