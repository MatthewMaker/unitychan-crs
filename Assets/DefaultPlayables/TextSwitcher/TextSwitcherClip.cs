using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class TextSwitcherClip : PlayableAsset, ITimelineClipAsset
{
    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public Color color = Color.white;
    public int fontSize = 14;
    public string text;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<TextSwitcherBehaviour>.Create(graph);
        var behaviour = playable.GetBehaviour();
        behaviour.color = color;
        behaviour.fontSize = fontSize;
        behaviour.text = text;
        return playable;
    }
}

