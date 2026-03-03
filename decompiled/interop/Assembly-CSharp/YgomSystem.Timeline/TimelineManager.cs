using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x200021C")]
public class TimelineManager : MonoBehaviour
{
	[Token(Token = "0x200021D")]
	internal class TimelineObjectDesc
	{
		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Stack<int> toidList;

		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool boostEnable;

		[Token(Token = "0x1700015A")]
		public string label
		{
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0xD3FB60", Offset = "0xD3ED60", VA = "0x180D3FB60")]
		public TimelineObjectDesc(string label, bool boostEnable)
		{
		}
	}

	[Token(Token = "0x200021E")]
	public enum EndEventType
	{
		[Token(Token = "0x4000B21")]
		NONE,
		[Token(Token = "0x4000B22")]
		AUTODESTROY,
		[Token(Token = "0x4000B23")]
		AUTORECYCLE
	}

	[Token(Token = "0x4000B12")]
	public const string TM_LABEL_DUEL = "Duel";

	[Token(Token = "0x4000B13")]
	public const string TM_LABEL_BASE = "Base";

	[Token(Token = "0x4000B14")]
	public const string GROUP_LABEL_DEFAULT = "DefaultGroup";

	[Token(Token = "0x4000B15")]
	public const string GROUP_LABEL_DUEL = "DuelGroup";

	[Token(Token = "0x4000B16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TimelineManager m_Instance;

	[Token(Token = "0x4000B17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, Dictionary<string, TimelineObjectDesc>> m_CachedTimelineObjectGroupTable;

	[Token(Token = "0x4000B18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TimelineObject> m_AllTimelineObjectInstanceTable;

	[Token(Token = "0x4000B19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform m_TimeLineRoot2D;

	[Token(Token = "0x4000B1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform m_TimeLineRoot3D;

	[Token(Token = "0x4000B1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform m_HidePool;

	[Token(Token = "0x4000B1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, Action> eventCallback;

	[Token(Token = "0x17000159")]
	private static TimelineManager instance
	{
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0xD3FA70", Offset = "0xD3EC70", VA = "0x180D3FA70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000C86")]
	[Address(RVA = "0xD3C710", Offset = "0xD3B910", VA = "0x180D3C710")]
	private static TimelineManager CreateTimelineManager()
	{
		return null;
	}

	[Token(Token = "0x6000C87")]
	[Address(RVA = "0xD3CDB0", Offset = "0xD3BFB0", VA = "0x180D3CDB0")]
	public static void DestroyAllTimelineObject()
	{
	}

	[Token(Token = "0x6000C88")]
	[Address(RVA = "0xD3F160", Offset = "0xD3E360", VA = "0x180D3F160")]
	public static void ResetTImelineTableOfGroup(string group, bool includeEndEventTypeNone = true)
	{
	}

	[Token(Token = "0x6000C89")]
	[Address(RVA = "0xD3EEB0", Offset = "0xD3E0B0", VA = "0x180D3EEB0")]
	private void ResetTImelineTableOfGroupInpl(string group, bool includeEndEventTypeNone)
	{
	}

	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0xD3D580", Offset = "0xD3C780", VA = "0x180D3D580")]
	public static void OpenTimelineAsync2D(string path, UnityAction<PlayableDirector> onLoaded, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
	{
	}

	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0xD3D670", Offset = "0xD3C870", VA = "0x180D3D670")]
	public static void OpenTimelineAsync2D(string group, string path, UnityAction<PlayableDirector> onLoaded, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
	{
	}

	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0xD3D750", Offset = "0xD3C950", VA = "0x180D3D750")]
	public static void OpenTimelineAsync3D(string path, UnityAction<PlayableDirector> onLoaded, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
	{
	}

	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0xD3D840", Offset = "0xD3CA40", VA = "0x180D3D840")]
	public static void OpenTimelineAsync3D(string group, string path, UnityAction<PlayableDirector> onLoaded, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
	{
	}

	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0xD3E8B0", Offset = "0xD3DAB0", VA = "0x180D3E8B0")]
	public static bool PreloadTimeline(string path, [Optional] Action<bool> onFinish, int instancenum = 1, bool boostEnable = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0xD3E810", Offset = "0xD3DA10", VA = "0x180D3E810")]
	public static bool PreloadTimeline(string group, string path, [Optional] Action<bool> onFinish, int instancenum = 1, bool boostEnable = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C90")]
	[Address(RVA = "0xD3E520", Offset = "0xD3D720", VA = "0x180D3E520")]
	private bool PreloadTimelineImpl(string group, string path, [Optional] Action<bool> onFinish, int instancenum = 1, bool boostEnable = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C91")]
	[Address(RVA = "0xD3DD60", Offset = "0xD3CF60", VA = "0x180D3DD60")]
	public static void OpenTimelineAsync(string path, UnityAction<PlayableDirector> onLoaded, Transform parent, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
	{
	}

	[Token(Token = "0x6000C92")]
	[Address(RVA = "0xD3DC90", Offset = "0xD3CE90", VA = "0x180D3DC90")]
	public static void OpenTimelineAsync(string group, string path, UnityAction<PlayableDirector> onLoaded, Transform parent, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
	{
	}

	[Token(Token = "0x6000C93")]
	[Address(RVA = "0xD3D920", Offset = "0xD3CB20", VA = "0x180D3D920")]
	private void OpenTimelineAsyncImpl(string group, string path, UnityAction<PlayableDirector> onLoaded, Transform parent, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
	{
	}

	[Token(Token = "0x6000C94")]
	[Address(RVA = "0xD3E450", Offset = "0xD3D650", VA = "0x180D3E450")]
	public static TimelineObject OpenTimeline(string path, Transform parent, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
	{
		return null;
	}

	[Token(Token = "0x6000C95")]
	[Address(RVA = "0xD3E390", Offset = "0xD3D590", VA = "0x180D3E390")]
	public static TimelineObject OpenTimeline(string group, string path, Transform parent, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
	{
		return null;
	}

	[Token(Token = "0x6000C96")]
	[Address(RVA = "0xD3DE30", Offset = "0xD3D030", VA = "0x180D3DE30")]
	private TimelineObject OpenTimelineImpl(string group, string path, Transform parent, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE, bool boostEnable = true)
	{
		return null;
	}

	[Token(Token = "0x6000C97")]
	[Address(RVA = "0xD3D2F0", Offset = "0xD3C4F0", VA = "0x180D3D2F0")]
	public static TimelineObject OpenTimeline2D(string path, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
	{
		return null;
	}

	[Token(Token = "0x6000C98")]
	[Address(RVA = "0xD3D220", Offset = "0xD3C420", VA = "0x180D3D220")]
	public static TimelineObject OpenTimeline2D(string group, string path, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
	{
		return null;
	}

	[Token(Token = "0x6000C99")]
	[Address(RVA = "0xD3D4A0", Offset = "0xD3C6A0", VA = "0x180D3D4A0")]
	public static TimelineObject OpenTimeline3D(string path, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
	{
		return null;
	}

	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0xD3D3D0", Offset = "0xD3C5D0", VA = "0x180D3D3D0")]
	public static TimelineObject OpenTimeline3D(string group, string path, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
	{
		return null;
	}

	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0xD3EC00", Offset = "0xD3DE00", VA = "0x180D3EC00")]
	public static bool RecycleTimeline(string path, TimelineObject timelineObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0xD3EC90", Offset = "0xD3DE90", VA = "0x180D3EC90")]
	public static bool RecycleTimeline(string group, string path, TimelineObject timelineObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0xD3CCC0", Offset = "0xD3BEC0", VA = "0x180D3CCC0")]
	public static bool DecreaseCachedTimelineObject(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0xD3CD40", Offset = "0xD3BF40", VA = "0x180D3CD40")]
	public static bool DecreaseCachedTimelineObject(string group, string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0xD3CA60", Offset = "0xD3BC60", VA = "0x180D3CA60")]
	public bool DecreaseCachedTimelineObjectImpl(string group, string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0xD3E960", Offset = "0xD3DB60", VA = "0x180D3E960")]
	public bool RecycleTimelineImpl(string group, string path, TimelineObject timelineObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0xD3F8F0", Offset = "0xD3EAF0", VA = "0x180D3F8F0")]
	public static void UpdateTimelineSpeed(string group, double speed)
	{
	}

	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0xD3F960", Offset = "0xD3EB60", VA = "0x180D3F960")]
	public static void UpdateTimelineSpeed(double speed)
	{
	}

	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0xD3F600", Offset = "0xD3E800", VA = "0x180D3F600")]
	public void UpdateBoostModeImpl(string group, double speed)
	{
	}

	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0xD3F410", Offset = "0xD3E610", VA = "0x180D3F410")]
	private void TimelineOnLoaded(TimelineObject to, UnityAction<PlayableDirector> onLoaded, Transform parent, [Optional] Action onStop, bool autoPlay = true, EndEventType endEvent = EndEventType.AUTORECYCLE)
	{
	}

	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0xD3ED20", Offset = "0xD3DF20", VA = "0x180D3ED20")]
	private void RegisterTimelineObejct(TimelineObject to)
	{
	}

	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0xD3F240", Offset = "0xD3E440", VA = "0x180D3F240")]
	public static void SetEventCallback(string label, Action callback)
	{
	}

	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0xD3D0B0", Offset = "0xD3C2B0", VA = "0x180D3D0B0")]
	public static void InvokeEventCallback(string label)
	{
	}

	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0xD3C690", Offset = "0xD3B890", VA = "0x180D3C690")]
	public static void ClearEventCallback()
	{
	}

	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public TimelineManager()
	{
	}
}
