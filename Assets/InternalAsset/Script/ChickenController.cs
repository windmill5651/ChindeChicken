using UnityEngine;

/// <summary>
/// キャラクターの名前空間です
/// </summary>
namespace Chicken.Game.Character
{

    /// <summary>
    ///   ChickenController
    ///   鶏を制御するクラスです。
    ///   
    /// Author:Windill
    /// </summary>
    public class ChickenController : MonoBehaviour
    {
        #region インスペクタ－設定フィールド

        /// <summary>
        /// ジャンプ力ぅ…ですかね
        /// </summary>
        [ SerializeField ]
        private float jumpPower = 5;

        /// <summary>
        /// 重力ぅ…ですかね
        /// </summary>
        [SerializeField]
        private float gravityForce = 5;

        #endregion


        #region フィールド/プロパティ

        /// <summary>
        /// キャラクターの高さです。
        /// </summary>
        private float height = 0;

        /// <summary>
        /// y軸に対してかかる力です
        /// </summary>
        private float heightForce = 0;

        bool isJump = false;

        #endregion


        #region メソッド

        // Use this for initialization
        void Start()
        {

        }


        /// <summary>
        /// 毎フレーム更新処理です。
        /// </summary>
        void Update()
        {

            var pos = transform.position;
            if ( Input.GetKeyDown( KeyCode.Space ) )
            {
                Jump();
            }

            //ジャンプ中ならジャンプの処理
            if ( isJump )
            {
                height += heightForce * Time.deltaTime;
                heightForce -= gravityForce * Time.deltaTime;
            }
            else
            {
                height = 0;
                heightForce = 0;
                isJump = false;
            }

            //高さが0未満にはならないようにする
            if ( height <= 0 )
            {
                height = 0;
                isJump = false;
            }

            // 位置を実際にセットする
            pos.y = height;
            transform.position = pos;
        }

        /// <summary>
        /// ジャンプです
        /// </summary>
        private void Jump()
        {
            // ジャンプ中は入力を受け付けない
            if ( isJump )
            {
                return;
            }
            // ジャンプ力をセットする
            heightForce = jumpPower;
            isJump = true;
        }

        #endregion

    }
}
