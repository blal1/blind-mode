using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200002D")]
[UxmlObject]
public class DataBinding : Binding, IDataSourceProvider
{
	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x0")]
	private static MethodInfo s_UpdateUIMethodInfo;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x20")]
	private BindingMode m_BindingMode;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x28")]
	private ConverterGroup m_SourceToUiConverters;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x30")]
	private ConverterGroup m_UiToSourceConverters;

	[Token(Token = "0x1700002B")]
	internal static MethodInfo updateUIMethod
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2991F40", Offset = "0x2991140", VA = "0x182991F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	[CreateProperty]
	public object dataSource
	{
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public Type dataSourceType
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	[CreateProperty]
	public PropertyPath dataSourcePath
	{
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2991DA0", Offset = "0x2990FA0", VA = "0x182991DA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(PropertyPath);
		}
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2992160", Offset = "0x2991360", VA = "0x182992160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	[CreateProperty]
	public BindingMode bindingMode
	{
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(BindingMode);
		}
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2992150", Offset = "0x2991350", VA = "0x182992150")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	[CreateProperty(ReadOnly = true)]
	public ConverterGroup sourceToUiConverters
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2991E00", Offset = "0x2991000", VA = "0x182991E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000031")]
	[CreateProperty(ReadOnly = true)]
	public ConverterGroup uiToSourceConverters
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2991EA0", Offset = "0x29910A0", VA = "0x182991EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x2991BE0", Offset = "0x2990DE0", VA = "0x182991BE0")]
	private static MethodInfo CacheReflectionInfo()
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x29919E0", Offset = "0x2990BE0", VA = "0x1829919E0")]
	public void ApplyConverterGroupToSource(ConverterGroup group)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x2991AE0", Offset = "0x2990CE0", VA = "0x182991AE0")]
	public void ApplyConverterGroupToUI(ConverterGroup group)
	{
	}

	[Token(Token = "0x600017E")]
	protected internal virtual BindingResult UpdateUI<TValue>(in BindingContext context, ref TValue value)
	{
		return default(BindingResult);
	}

	[Token(Token = "0x600017F")]
	protected internal virtual BindingResult UpdateSource<TValue>(in BindingContext context, ref TValue value)
	{
		return default(BindingResult);
	}

	[Token(Token = "0x6000180")]
	internal static string GetSetValueErrorString<TValue>(VisitReturnCode returnCode, object source, in PropertyPath sourcePath, object target, in BindingId targetPath, TValue extractedValueFromSource)
	{
		return null;
	}
}
