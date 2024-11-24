using Cysharp.Threading.Tasks;
using UnityEngine;

/// <summary>Effectの設定を管理する</summary>
public class EffectManager : SingletonMonoBehaviour<EffectManager>
{
    private EffectSettings _settings;

    //Effectを再生する
    public async UniTask Show(string effectName, Vector2 firstPos, Vector2 targetPos)
    {
        EffectSettings effect = (EffectSettings)Resources.Load(effectName);

        if (effect == null)
        {
            Debug.LogError("Effectが見つかりません");
            return;
        }

        //Effectの生成
        EffectSettings effectSettings = Instantiate(effect, firstPos, Quaternion.identity);
        
        //Todo:Effectを止める方法　EffectSettingsで再生が終了したことを知らせる関数を書く
    }
}
