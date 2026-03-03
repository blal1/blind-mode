using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000500")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x4001066")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<VisualElement> m_ApplyStyleUpdateList;

	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0x30")]
	private HashSet<VisualElement> m_TransitionPropertyUpdateList;

	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsApplyingStyles;

	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_Version;

	[Token(Token = "0x400106A")]
	[FieldOffset(Offset = "0x40")]
	private uint m_LastVersion;

	[Token(Token = "0x400106B")]
	[FieldOffset(Offset = "0x48")]
	private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal;

	[Token(Token = "0x400106C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string s_Description;

	[Token(Token = "0x400106D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker s_ProfilerMarker;

	[Token(Token = "0x17000964")]
	public override ProfilerMarker profilerMarker
	{
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x2A42340", Offset = "0x2A41540", VA = "0x182A42340", Slot = "12")]
		get
		{
			return default(ProfilerMarker);
		}
	}

	[Token(Token = "0x17000965")]
	protected bool disposed
	{
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x3E1DE0", Offset = "0x3E0FE0", VA = "0x1803E1DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x3E1DF0", Offset = "0x3E0FF0", VA = "0x1803E1DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60023F1")]
	[Address(RVA = "0x2A41CF0", Offset = "0x2A40EF0", VA = "0x182A41CF0", Slot = "15")]
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x60023F2")]
	[Address(RVA = "0x2A41DB0", Offset = "0x2A40FB0", VA = "0x182A41DB0", Slot = "14")]
	public override void Update()
	{
	}

	[Token(Token = "0x60023F5")]
	[Address(RVA = "0x2A41CB0", Offset = "0x2A40EB0", VA = "0x182A41CB0", Slot = "13")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x60023F6")]
	[Address(RVA = "0x2A41B80", Offset = "0x2A40D80", VA = "0x182A41B80")]
	private void ApplyStyles()
	{
	}

	[Token(Token = "0x60023F7")]
	[Address(RVA = "0x2A42250", Offset = "0x2A41450", VA = "0x182A42250")]
	public VisualTreeStyleUpdater()
	{
	}
}
