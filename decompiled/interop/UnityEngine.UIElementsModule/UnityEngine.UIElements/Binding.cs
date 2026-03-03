using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200001C")]
[UxmlObject]
public abstract class Binding
{
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x10")]
	private bool m_Dirty;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x14")]
	private BindingUpdateTrigger m_UpdateTrigger;

	[Token(Token = "0x4000038")]
	internal const string k_UpdateTriggerTooltip = "This informs the binding system of whether the binding object should be updated on every frame, when a change occurs in the source or on every frame if change detection is impossible, and when explicitly marked as dirty.";

	[Token(Token = "0x1700001B")]
	public bool isDirty
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001C")]
	[CreateProperty]
	public BindingUpdateTrigger updateTrigger
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		get
		{
			return default(BindingUpdateTrigger);
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		set
		{
		}
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x29790D0", Offset = "0x29782D0", VA = "0x1829790D0")]
	public static void SetGlobalLogLevel(BindingLogLevel logLevel)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2979130", Offset = "0x2978330", VA = "0x182979130")]
	public static void SetPanelLogLevel(IPanel panel, BindingLogLevel logLevel)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2979050", Offset = "0x2978250", VA = "0x182979050")]
	public static void ResetPanelLogLevel(IPanel panel)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x21F4520", Offset = "0x21F3720", VA = "0x1821F4520")]
	internal Binding()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
	public void MarkDirty()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
	internal void ClearDirty()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	protected internal virtual void OnActivated(in BindingActivationContext context)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	protected internal virtual void OnDeactivated(in BindingActivationContext context)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	protected internal virtual void OnDataSourceChanged(in DataSourceContextChanged context)
	{
	}
}
