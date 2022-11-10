using UnityEngine;

namespace KUMO
{

    #region 事件區域

    /// <summary>
    /// 傷害爆炸
    /// </summary>

    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;

       

        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

               
                Destroy(gameObject);
            }

        }
           #endregion
        

        
    }

}

