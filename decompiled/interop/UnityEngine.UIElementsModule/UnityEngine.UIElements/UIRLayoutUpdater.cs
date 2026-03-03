using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002A5")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class UIRLayoutUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string s_Description;

	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker s_ProfilerMarker;

	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x10")]
	private static readonly ProfilerMarker k_ComputeLayoutMarker;

	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x18")]
	private static readonly ProfilerMarker k_UpdateSubTreeMarker;

	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x20")]
	private static readonly ProfilerMarker k_DispatchChangeEventsMarker;

	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x28")]
	private List<(Rect, Rect, VisualElement)> changeEventsList;

	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x30")]
	private List<VisualElement> missedHierarchyChangeEventsList;

	[Token(Token = "0x17000386")]
	public override ProfilerMarker profilerMarker
	{
		[Token(Token = "0x6001278")]
		[Address(RVA = "0x2B713D0", Offset = "0x2B705D0", VA = "0x182B713D0", Slot = "12")]
		get
		{
			return default(ProfilerMarker);
		}
	}

	[Token(Token = "0x6001279")]
	[Address(RVA = "0x2B70330", Offset = "0x2B6F530", VA = "0x182B70330", Slot = "15")]
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x600127A")]
	[Address(RVA = "0x2B70EB0", Offset = "0x2B700B0", VA = "0x182B70EB0", Slot = "14")]
	public override void Update()
	{
	}

	[Token(Token = "0x600127B")]
	[Address(RVA = "0x2B703A0", Offset = "0x2B6F5A0", VA = "0x182B703A0")]
	private static bool UpdateHierarchyDisplayed(VisualElement ve, List<(Rect, Rect, VisualElement)> changeEvents, bool inheritedDisplayed = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600127C")]
	[Address(RVA = "0x2B70650", Offset = "0x2B6F850", VA = "0x182B70650")]
	private void UpdateSubTree(VisualElement ve, List<(Rect, Rect, VisualElement)> changeEvents)
	{
	}

	[Token(Token = "0x600127D")]
	[Address(RVA = "0x2B6FDF0", Offset = "0x2B6EFF0", VA = "0x182B6FDF0")]
	private void DispatchChangeEvents(List<(Rect, Rect, VisualElement)> changeEvents, int currentLayoutPass)
	{
	}

	[Token(Token = "0x600127E")]
	[Address(RVA = "0x2B70090", Offset = "0x2B6F290", VA = "0x182B70090")]
	private void DispatchMissedHierarchyChangeEvents(List<VisualElement> missedHierarchyChangeEvents, int currentLayoutPass)
	{
	}

	[Token(Token = "0x600127F")]
	[Address(RVA = "0x2B71310", Offset = "0x2B70510", VA = "0x182B71310")]
	public UIRLayoutUpdater()
	{
	}
}
