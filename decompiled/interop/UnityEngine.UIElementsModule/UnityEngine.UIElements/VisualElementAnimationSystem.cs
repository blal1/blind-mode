using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004F9")]
internal class VisualElementAnimationSystem : BaseVisualTreeUpdater
{
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<IValueAnimationUpdate> m_Animations;

	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x30")]
	private List<IValueAnimationUpdate> m_IterationList;

	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x38")]
	private bool m_HasNewAnimations;

	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x39")]
	private bool m_IterationListDirty;

	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string s_Description;

	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker s_ProfilerMarker;

	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string s_StylePropertyAnimationDescription;

	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x18")]
	private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker;

	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x40")]
	private long lastUpdate;

	[Token(Token = "0x17000961")]
	public override ProfilerMarker profilerMarker
	{
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x2A3C1F0", Offset = "0x2A3B3F0", VA = "0x182A3C1F0", Slot = "12")]
		get
		{
			return default(ProfilerMarker);
		}
	}

	[Token(Token = "0x17000962")]
	private static ProfilerMarker stylePropertyAnimationProfilerMarker
	{
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x2A3C240", Offset = "0x2A3B440", VA = "0x182A3C240")]
		get
		{
			return default(ProfilerMarker);
		}
	}

	[Token(Token = "0x60023CD")]
	[Address(RVA = "0x2A3BAF0", Offset = "0x2A3ACF0", VA = "0x182A3BAF0")]
	public void UnregisterAnimation(IValueAnimationUpdate anim)
	{
	}

	[Token(Token = "0x60023CE")]
	[Address(RVA = "0x2A3BB50", Offset = "0x2A3AD50", VA = "0x182A3BB50")]
	public void UnregisterAnimations(List<IValueAnimationUpdate> anims)
	{
	}

	[Token(Token = "0x60023CF")]
	[Address(RVA = "0x2A3B950", Offset = "0x2A3AB50", VA = "0x182A3B950")]
	public void RegisterAnimation(IValueAnimationUpdate anim)
	{
	}

	[Token(Token = "0x60023D0")]
	[Address(RVA = "0x2A3B9B0", Offset = "0x2A3ABB0", VA = "0x182A3B9B0")]
	public void RegisterAnimations(List<IValueAnimationUpdate> anims)
	{
	}

	[Token(Token = "0x60023D1")]
	[Address(RVA = "0x2A3BC90", Offset = "0x2A3AE90", VA = "0x182A3BC90", Slot = "14")]
	public override void Update()
	{
	}

	[Token(Token = "0x60023D2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x2A3C120", Offset = "0x2A3B320", VA = "0x182A3C120")]
	public VisualElementAnimationSystem()
	{
	}
}
