using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x2000224")]
public class TimelineObject : MonoBehaviour
{
	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x30")]
	public TimelineManager.EndEventType endEventType;

	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x38")]
	public UnityAction onDestroy;

	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x40")]
	protected PlayableDirector m_PlayableDirector;

	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x48")]
	protected Queue<UnityAction<PlayableDirector>> onStopQueue;

	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x50")]
	protected Queue<UnityAction<PlayableDirector>> onPlayQueue;

	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0x58")]
	protected Queue<UnityAction<PlayableDirector>> onPauseQueue;

	[Token(Token = "0x1700015B")]
	public PlayState state
	{
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0xD409E0", Offset = "0xD3FBE0", VA = "0x180D409E0")]
		get
		{
			return default(PlayState);
		}
	}

	[Token(Token = "0x1700015C")]
	public double time
	{
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0xD40A00", Offset = "0xD3FC00", VA = "0x180D40A00")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x1700015D")]
	public string path
	{
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700015E")]
	public string group
	{
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700015F")]
	public PlayableDirector playableDirector
	{
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0xD3FD20", Offset = "0xD3EF20", VA = "0x180D3FD20")]
	public static TimelineObject CreateTimelineObject(GameObject gob, string path, string group)
	{
		return null;
	}

	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0xD3FCC0", Offset = "0xD3EEC0", VA = "0x180D3FCC0")]
	public void AddOnStopCallBack(UnityAction<PlayableDirector> onstop)
	{
	}

	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0xD3FC60", Offset = "0xD3EE60", VA = "0x180D3FC60")]
	public void AddOnPlayCallback(UnityAction<PlayableDirector> onplay)
	{
	}

	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0xD3FC00", Offset = "0xD3EE00", VA = "0x180D3FC00")]
	public void AddOnPauseCallback(UnityAction<PlayableDirector> onpause)
	{
	}

	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0xD405C0", Offset = "0xD3F7C0", VA = "0x180D405C0")]
	private void OnPlayableDirectorStop(PlayableDirector pd)
	{
	}

	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0xD407C0", Offset = "0xD3F9C0", VA = "0x180D407C0")]
	public void Play()
	{
	}

	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0xD409B0", Offset = "0xD3FBB0", VA = "0x180D409B0")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0xD407A0", Offset = "0xD3F9A0", VA = "0x180D407A0")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0xD408B0", Offset = "0xD3FAB0", VA = "0x180D408B0")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0xD40080", Offset = "0xD3F280", VA = "0x180D40080")]
	public void Evaluate()
	{
	}

	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0xD408D0", Offset = "0xD3FAD0", VA = "0x180D408D0")]
	public void SkipTo(float target, float start = 0f)
	{
	}

	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0xD400A0", Offset = "0xD3F2A0", VA = "0x180D400A0")]
	public LabeledPlayableController GetLabeledPlayableController()
	{
		return null;
	}

	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0xD40020", Offset = "0xD3F220", VA = "0x180D40020")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0xD407E0", Offset = "0xD3F9E0", VA = "0x180D407E0")]
	public void Recycle()
	{
	}

	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0xD40130", Offset = "0xD3F330", VA = "0x180D40130")]
	public void OnCached()
	{
	}

	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0xD40490", Offset = "0xD3F690", VA = "0x180D40490")]
	private void OnPlayableDirectorPlay(PlayableDirector pd)
	{
	}

	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0xD40360", Offset = "0xD3F560", VA = "0x180D40360")]
	private void OnPlayableDirectorPause(PlayableDirector pd)
	{
	}

	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0xD40850", Offset = "0xD3FA50", VA = "0x180D40850")]
	private void ResetEventQueue(Queue<UnityAction<PlayableDirector>> eventQueue)
	{
	}

	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0xD40240", Offset = "0xD3F440", VA = "0x180D40240")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0xD409D0", Offset = "0xD3FBD0", VA = "0x180D409D0")]
	public TimelineObject()
	{
	}
}
