using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Token(Token = "0x20001F9")]
[RequireComponent(typeof(PlayableDirector))]
public class LabeledPlayableController : MonoBehaviour
{
	[Token(Token = "0x20001FA")]
	private class LabelInfo
	{
		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, TimelineClip> m_TrackClips;

		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, LabelDirectorWrapMode> m_LabelModeTable;

		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0x20")]
		private string[] m_ClipLabels;

		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x28")]
		private PlayableAsset m_SourcePlayableAsset;

		[Token(Token = "0x17000155")]
		public bool initialized
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0xC0BA10", Offset = "0xC0AC10", VA = "0x180C0BA10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0xC0B070", Offset = "0xC0A270", VA = "0x180C0B070")]
		public void Import(LabelMixerBehaviour labelMixer, PlayableDirector director)
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0xC0AEF0", Offset = "0xC0A0F0", VA = "0x180C0AEF0")]
		public void CheckInitialize(PlayableDirector director)
		{
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0xC0B840", Offset = "0xC0AA40", VA = "0x180C0B840")]
		public bool SetLabelClipExWrapMode(string label, LabelDirectorWrapMode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0xC0AFE0", Offset = "0xC0A1E0", VA = "0x180C0AFE0")]
		public bool ExistsLabel(string label, PlayableDirector director)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0xC0B4B0", Offset = "0xC0A6B0", VA = "0x180C0B4B0")]
		public TimelineClip SearchClip(string label, PlayableDirector director)
		{
			return null;
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0xC0B780", Offset = "0xC0A980", VA = "0x180C0B780")]
		public LabelDirectorWrapMode SearchWrapModeOrDefault(string label, PlayableDirector director, LabelDirectorWrapMode defaultValue)
		{
			return default(LabelDirectorWrapMode);
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0xC0B690", Offset = "0xC0A890", VA = "0x180C0B690")]
		public string SearchNextLabel(string currentLabel, PlayableDirector director)
		{
			return null;
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0xC0B570", Offset = "0xC0A770", VA = "0x180C0B570")]
		public void SearchGoThroughLabels(string fromLabel, PlayableDirector director, LabelDirectorWrapMode defaultValue, List<string> res)
		{
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0xC0B950", Offset = "0xC0AB50", VA = "0x180C0B950")]
		public LabelInfo()
		{
		}
	}

	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x20")]
	private readonly LabelInfo m_LabelInfo;

	[Token(Token = "0x4000A87")]
	[FieldOffset(Offset = "0x28")]
	private PlayableDirector m_Director;

	[Token(Token = "0x4000A88")]
	[FieldOffset(Offset = "0x30")]
	private DirectorWrapMode m_WrapMode;

	[Token(Token = "0x4000A89")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private LabelDirectorWrapMode m_LabelWrapMode;

	[Token(Token = "0x4000A8A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string m_PlayLabel;

	[Token(Token = "0x4000A8B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool m_CalcLoopClipOutrangeTime;

	[Token(Token = "0x4000A8C")]
	[FieldOffset(Offset = "0x48")]
	private double m_LastCheckedTime;

	[Token(Token = "0x1700014F")]
	public DirectorWrapMode wrapMode
	{
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(DirectorWrapMode);
		}
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0xC0D580", Offset = "0xC0C780", VA = "0x180C0D580")]
		set
		{
		}
	}

	[Token(Token = "0x17000150")]
	public LabelDirectorWrapMode labelWrapMode
	{
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(LabelDirectorWrapMode);
		}
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x9941B0", Offset = "0x9933B0", VA = "0x1809941B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000151")]
	public PlayState state
	{
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0xC0D2A0", Offset = "0xC0C4A0", VA = "0x180C0D2A0")]
		get
		{
			return default(PlayState);
		}
	}

	[Token(Token = "0x17000152")]
	public string playLabel
	{
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000153")]
	public TimelineClip currentClip
	{
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0xC0D210", Offset = "0xC0C410", VA = "0x180C0D210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000154")]
	public bool initialized
	{
		[Token(Token = "0x6000BED")]
		[Address(RVA = "0xC0D240", Offset = "0xC0C440", VA = "0x180C0D240")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000009")]
	public event Action<string, LabeledPlayableController> reachedLabelWrapEdge
	{
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0xC0D0B0", Offset = "0xC0C2B0", VA = "0x180C0D0B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0xC0D420", Offset = "0xC0C620", VA = "0x180C0D420")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action<string, LabeledPlayableController> stopped
	{
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0xC0D160", Offset = "0xC0C360", VA = "0x180C0D160")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0xC0D4D0", Offset = "0xC0C6D0", VA = "0x180C0D4D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<string, LabeledPlayableController> played
	{
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0xC0D000", Offset = "0xC0C200", VA = "0x180C0D000")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0xC0D370", Offset = "0xC0C570", VA = "0x180C0D370")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event Action<string, LabeledPlayableController> paused
	{
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0xC0CF50", Offset = "0xC0C150", VA = "0x180C0CF50")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0xC0D2C0", Offset = "0xC0C4C0", VA = "0x180C0D2C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0xC0C8E0", Offset = "0xC0BAE0", VA = "0x180C0C8E0")]
	public TimelineClip SearchClip(string label, PlayableDirector director)
	{
		return null;
	}

	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0xC0C900", Offset = "0xC0BB00", VA = "0x180C0C900")]
	public void SearchGoThroughLabels(string fromLabel, PlayableDirector director, LabelDirectorWrapMode defaultValue, List<string> res)
	{
	}

	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0xC0C3D0", Offset = "0xC0B5D0", VA = "0x180C0C3D0")]
	public static LabeledPlayableController Create(PlayableDirector target)
	{
		return null;
	}

	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0xC0C200", Offset = "0xC0B400", VA = "0x180C0C200")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0xC0CA20", Offset = "0xC0BC20", VA = "0x180C0CA20")]
	private void Start()
	{
	}

	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0xC0C480", Offset = "0xC0B680", VA = "0x180C0C480")]
	public void OnCreatedLabelMixer(LabelMixerBehaviour labelMixer)
	{
	}

	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0xC0C610", Offset = "0xC0B810", VA = "0x180C0C610")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0xC0C960", Offset = "0xC0BB60", VA = "0x180C0C960")]
	public bool SetLabelClipExWrapMode(string label, LabelDirectorWrapMode mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0xC0C690", Offset = "0xC0B890", VA = "0x180C0C690")]
	public void PlayLabel(string label)
	{
	}

	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0xC0C630", Offset = "0xC0B830", VA = "0x180C0C630")]
	public void PlayLabel(string label, PlayableAsset asset)
	{
	}

	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0xC0C680", Offset = "0xC0B880", VA = "0x180C0C680")]
	public void PlayLabel(string label, LabelDirectorWrapMode mode)
	{
	}

	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0xC0C800", Offset = "0xC0BA00", VA = "0x180C0C800")]
	public void PlayLabel(string label, PlayableAsset asset, LabelDirectorWrapMode mode)
	{
	}

	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0xC0C850", Offset = "0xC0BA50", VA = "0x180C0C850")]
	public bool PlayNextLabel()
	{
		return default(bool);
	}

	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0xC0C930", Offset = "0xC0BB30", VA = "0x180C0C930")]
	public string SearchNextLabel()
	{
		return null;
	}

	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0xC0C8C0", Offset = "0xC0BAC0", VA = "0x180C0C8C0")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0xB27940", Offset = "0xB26B40", VA = "0x180B27940")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0xC0C420", Offset = "0xC0B620", VA = "0x180C0C420")]
	public bool IsPlayingLabel(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0xC0CA80", Offset = "0xC0BC80", VA = "0x180C0CA80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C00")]
	[Address(RVA = "0xC0C5E0", Offset = "0xC0B7E0", VA = "0x180C0C5E0")]
	private void OnStopped(PlayableDirector director)
	{
	}

	[Token(Token = "0x6000C01")]
	[Address(RVA = "0xC0C560", Offset = "0xC0B760", VA = "0x180C0C560")]
	private void OnPlayed(PlayableDirector director)
	{
	}

	[Token(Token = "0x6000C02")]
	[Address(RVA = "0xC0C530", Offset = "0xC0B730", VA = "0x180C0C530")]
	private void OnPaused(PlayableDirector director)
	{
	}

	[Token(Token = "0x6000C03")]
	[Address(RVA = "0xC0CE30", Offset = "0xC0C030", VA = "0x180C0CE30")]
	public LabeledPlayableController()
	{
	}
}
