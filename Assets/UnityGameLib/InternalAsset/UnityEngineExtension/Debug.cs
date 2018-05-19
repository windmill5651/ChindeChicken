using UnityEngine;

/// <summary>
///  Debug
///  デバッグ要の機能をまとめたクラスです。
///  
/// Author:Windmill
/// </summary>
public static class Debug
{
    #region フィールド/プロパティ

    /// <summary>
    /// ロガーです。
    /// </summary>
    private static ILogger logger = null;

    /// <summary>
    /// ロガーへのアクセサです。
    /// </summary>
    private static ILogger Logger
    {
        get
        {
            if ( logger == null )
            {
                logger = UnityEngine.Debug.unityLogger;
            }

            return logger;
        }
    }

    #endregion

    #region メソッド

    /// <summary>
    /// ログのフィルターを指定します。
    /// </summary>
    /// <param name="logType">ログのタイプです。</param>
    public static void LogFilter( LogType logType )
    {
        Logger.filterLogType = logType;
    }

    /// <summary>
    /// ログ出力をします。
    /// </summary>
    /// <param name="message">ログです</param>
    public static void Log( object message )
    {
        Logger.Log( message );
    }

    /// <summary>
    /// ワーニングのログを出します。
    /// </summary>
    /// <param name="tag">タグ</param>
    /// <param name="message">ログメッセージ</param>
    public static void LogWarning( string tag = "", object message )
    {
        Logger.LogWarning( tag, message );
    }

    #endregion

}
