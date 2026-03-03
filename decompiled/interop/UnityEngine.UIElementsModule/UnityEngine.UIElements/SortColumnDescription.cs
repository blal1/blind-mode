using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x200011D")]
[UxmlObject]
public class SortColumnDescription : INotifyBindablePropertyChanged
{
	[Token(Token = "0x200011E")]
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : SortColumnDescription, new()
	{
		[Token(Token = "0x6000908")]
		public UxmlObjectFactory()
		{
		}
	}

	[Token(Token = "0x200011F")]
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectFactory : UxmlObjectFactory<SortColumnDescription>
	{
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x2AEF8B0", Offset = "0x2AEEAB0", VA = "0x182AEF8B0")]
		public UxmlObjectFactory()
		{
		}
	}

	[Token(Token = "0x2000120")]
	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : SortColumnDescription
	{
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlStringAttributeDescription m_ColumnName;

		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlIntAttributeDescription m_ColumnIndex;

		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlEnumAttributeDescription<SortDirection> m_SortDescription;

		[Token(Token = "0x600090A")]
		public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600090B")]
		public UxmlObjectTraits()
		{
		}
	}

	[Token(Token = "0x40005A4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly BindingId columnNameProperty;

	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0x98")]
	private static readonly BindingId columnIndexProperty;

	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x130")]
	private static readonly BindingId directionProperty;

	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private int m_ColumnIndex;

	[Token(Token = "0x40005A8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string m_ColumnName;

	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SortDirection m_SortDirection;

	[Token(Token = "0x17000182")]
	[CreateProperty]
	public string columnName
	{
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x2AEBBB0", Offset = "0x2AEADB0", VA = "0x182AEBBB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000183")]
	[CreateProperty]
	public int columnIndex
	{
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x2AEBB20", Offset = "0x2AEAD20", VA = "0x182AEBB20")]
		set
		{
		}
	}

	[Token(Token = "0x17000184")]
	public Column column
	{
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000185")]
	[CreateProperty]
	public SortDirection direction
	{
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(SortDirection);
		}
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x2AEBC60", Offset = "0x2AEAE60", VA = "0x182AEBC60")]
		set
		{
		}
	}

	[Token(Token = "0x14000021")]
	public event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x2AEB910", Offset = "0x2AEAB10", VA = "0x182AEB910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x2AEBA70", Offset = "0x2AEAC70", VA = "0x182AEBA70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000022")]
	internal event Action<SortColumnDescription> changed
	{
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x2AEB860", Offset = "0x2AEAA60", VA = "0x182AEB860")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x2AEB9C0", Offset = "0x2AEABC0", VA = "0x182AEB9C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000903")]
	[Address(RVA = "0x670FF0", Offset = "0x6701F0", VA = "0x180670FF0")]
	public SortColumnDescription()
	{
	}

	[Token(Token = "0x6000904")]
	[Address(RVA = "0x2AEB730", Offset = "0x2AEA930", VA = "0x182AEB730")]
	public SortColumnDescription(int columnIndex, SortDirection direction)
	{
	}

	[Token(Token = "0x6000905")]
	[Address(RVA = "0x2AEB5F0", Offset = "0x2AEA7F0", VA = "0x182AEB5F0")]
	public SortColumnDescription(string columnName, SortDirection direction)
	{
	}

	[Token(Token = "0x6000906")]
	[Address(RVA = "0x2AEB250", Offset = "0x2AEA450", VA = "0x182AEB250")]
	private void NotifyPropertyChanged(in BindingId property)
	{
	}
}
