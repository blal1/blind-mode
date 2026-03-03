using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002B4")]
internal class UIRRepaintUpdater : BaseVisualTreeUpdater, IPanelRenderer
{
	[Token(Token = "0x4000AE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private BaseVisualElementPanel attachedPanel;

	[Token(Token = "0x4000AE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal RenderChain renderChain;

	[Token(Token = "0x4000AEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string s_Description;

	[Token(Token = "0x4000AEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker s_ProfilerMarker;

	[Token(Token = "0x4000AEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_ForceGammaRendering;

	[Token(Token = "0x4000AED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private uint m_VertexBudget;

	[Token(Token = "0x17000393")]
	public override ProfilerMarker profilerMarker
	{
		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x2B722F0", Offset = "0x2B714F0", VA = "0x182B722F0", Slot = "12")]
		get
		{
			return default(ProfilerMarker);
		}
	}

	[Token(Token = "0x17000394")]
	public bool forceGammaRendering
	{
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x2B72340", Offset = "0x2B71540", VA = "0x182B72340", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x17000395")]
	public uint vertexBudget
	{
		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x5EA1B0", Offset = "0x5E93B0", VA = "0x1805EA1B0", Slot = "18")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x2B72350", Offset = "0x2B71550", VA = "0x182B72350", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x17000396")]
	public bool drawStats
	{
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000397")]
	public bool breakBatches
	{
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x4166B0", Offset = "0x4158B0", VA = "0x1804166B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000398")]
	protected bool disposed
	{
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x648660", Offset = "0x647860", VA = "0x180648660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0xE7A000", Offset = "0xE79200", VA = "0x180E7A000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x2B72270", Offset = "0x2B71470", VA = "0x182B72270")]
	public UIRRepaintUpdater()
	{
	}

	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x2B71D70", Offset = "0x2B70F70", VA = "0x182B71D70", Slot = "15")]
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x2B72040", Offset = "0x2B71240", VA = "0x182B72040", Slot = "14")]
	public override void Update()
	{
	}

	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x2B71F10", Offset = "0x2B71110", VA = "0x182B71F10", Slot = "21")]
	public void Render()
	{
	}

	[Token(Token = "0x60012D3")]
	[Address(RVA = "0x2B71690", Offset = "0x2B70890", VA = "0x182B71690", Slot = "22")]
	protected virtual RenderChain CreateRenderChain()
	{
		return null;
	}

	[Token(Token = "0x60012D4")]
	[Address(RVA = "0x2B72160", Offset = "0x2B71360", VA = "0x182B72160")]
	static UIRRepaintUpdater()
	{
	}

	[Token(Token = "0x60012D5")]
	[Address(RVA = "0x2B71B10", Offset = "0x2B70D10", VA = "0x182B71B10")]
	private static void OnGraphicsResourcesRecreate(bool recreate)
	{
	}

	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x2B71CE0", Offset = "0x2B70EE0", VA = "0x182B71CE0")]
	private void OnPanelChanged(BaseVisualElementPanel obj)
	{
	}

	[Token(Token = "0x60012D7")]
	[Address(RVA = "0x2B71420", Offset = "0x2B70620", VA = "0x182B71420")]
	private void AttachToPanel()
	{
	}

	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x2B717F0", Offset = "0x2B709F0", VA = "0x182B717F0")]
	private void DetachFromPanel()
	{
	}

	[Token(Token = "0x60012D9")]
	[Address(RVA = "0x2B71A50", Offset = "0x2B70C50", VA = "0x182B71A50")]
	private void InitRenderChain()
	{
	}

	[Token(Token = "0x60012DA")]
	[Address(RVA = "0x2B71CD0", Offset = "0x2B70ED0", VA = "0x182B71CD0", Slot = "20")]
	public void Reset()
	{
	}

	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x2B71700", Offset = "0x2B70900", VA = "0x182B71700")]
	private void DestroyRenderChain()
	{
	}

	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x2B71CD0", Offset = "0x2B70ED0", VA = "0x182B71CD0")]
	private void OnPanelIsFlatChanged()
	{
	}

	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x2B71CD0", Offset = "0x2B70ED0", VA = "0x182B71CD0")]
	private void OnPanelAtlasChanged()
	{
	}

	[Token(Token = "0x60012DE")]
	[Address(RVA = "0x2B71CD0", Offset = "0x2B70ED0", VA = "0x182B71CD0")]
	private void OnPanelDrawsInCamerasChanged()
	{
	}

	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x2B71D00", Offset = "0x2B70F00", VA = "0x182B71D00")]
	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, [Optional] IReadOnlyList<VisualElement> additionalContext)
	{
	}

	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x2B71FA0", Offset = "0x2B711A0", VA = "0x182B71FA0")]
	private void ResetAllElementsDataRecursive(VisualElement ve)
	{
	}

	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x2B71A20", Offset = "0x2B70C20", VA = "0x182B71A20", Slot = "13")]
	protected override void Dispose(bool disposing)
	{
	}
}
