using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004FA")]
internal class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x28")]
	private uint m_Version;

	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_LastVersion;

	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string s_Description;

	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ProfilerMarker s_ProfilerMarker;

	[Token(Token = "0x17000963")]
	public override ProfilerMarker profilerMarker
	{
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x2A3F9E0", Offset = "0x2A3EBE0", VA = "0x182A3F9E0", Slot = "12")]
		get
		{
			return default(ProfilerMarker);
		}
	}

	[Token(Token = "0x60023D6")]
	[Address(RVA = "0x2A3F740", Offset = "0x2A3E940", VA = "0x182A3F740", Slot = "15")]
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x60023D7")]
	[Address(RVA = "0x2A3F700", Offset = "0x2A3E900", VA = "0x182A3F700")]
	protected static VisualElementFlags GetChildrenMustDirtyFlags(VisualElement ve, VersionChangeType versionChangeType)
	{
		return default(VisualElementFlags);
	}

	[Token(Token = "0x60023D8")]
	[Address(RVA = "0x2A3F5C0", Offset = "0x2A3E7C0", VA = "0x182A3F5C0")]
	protected static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags)
	{
	}

	[Token(Token = "0x60023D9")]
	[Address(RVA = "0x2A3F500", Offset = "0x2A3E700", VA = "0x182A3F500")]
	private static void DirtyBoundingBoxHierarchy(VisualElement ve)
	{
	}

	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x2A3F6B0", Offset = "0x2A3E8B0", VA = "0x182A3F6B0")]
	protected static void DirtyParentHierarchy(VisualElement ve, VisualElementFlags flags)
	{
	}

	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x2A3F8C0", Offset = "0x2A3EAC0", VA = "0x182A3F8C0", Slot = "14")]
	public override void Update()
	{
	}

	[Token(Token = "0x60023DC")]
	[Address(RVA = "0x2A3F9D0", Offset = "0x2A3EBD0", VA = "0x182A3F9D0")]
	public VisualTreeHierarchyFlagsUpdater()
	{
	}
}
