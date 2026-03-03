using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004FD")]
internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x20004FE")]
	private enum State
	{
		[Token(Token = "0x4001060")]
		Waiting,
		[Token(Token = "0x4001061")]
		TrackingAddOrMove,
		[Token(Token = "0x4001062")]
		TrackingRemove
	}

	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0x28")]
	private State m_State;

	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0x30")]
	private VisualElement m_CurrentChangeElement;

	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0x38")]
	private VisualElement m_CurrentChangeParent;

	[Token(Token = "0x60023E2")]
	protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type);

	[Token(Token = "0x60023E3")]
	[Address(RVA = "0x2A2A250", Offset = "0x2A29450", VA = "0x182A2A250", Slot = "15")]
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x60023E4")]
	[Address(RVA = "0x2A2A680", Offset = "0x2A29880", VA = "0x182A2A680", Slot = "14")]
	public override void Update()
	{
	}

	[Token(Token = "0x60023E5")]
	[Address(RVA = "0x2A2A530", Offset = "0x2A29730", VA = "0x182A2A530")]
	private void ProcessNewChange(VisualElement ve)
	{
	}

	[Token(Token = "0x60023E6")]
	[Address(RVA = "0x2A2A470", Offset = "0x2A29670", VA = "0x182A2A470")]
	private void ProcessAddOrMove(VisualElement ve)
	{
	}

	[Token(Token = "0x60023E7")]
	[Address(RVA = "0x2A2A5E0", Offset = "0x2A297E0", VA = "0x182A2A5E0")]
	private void ProcessRemove(VisualElement ve)
	{
	}

	[Token(Token = "0x60023E8")]
	[Address(RVA = "0x2A2A740", Offset = "0x2A29940", VA = "0x182A2A740")]
	protected BaseVisualTreeHierarchyTrackerUpdater()
	{
	}
}
