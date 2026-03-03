using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000067")]
internal class ReusableCollectionItem
{
	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x38")]
	protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback;

	[Token(Token = "0x17000075")]
	public virtual VisualElement rootElement
	{
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000076")]
	public VisualElement bindableElement
	{
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000077")]
	public ValueAnimation<StyleValues> animator
	{
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000078")]
	public int index
	{
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000079")]
	public int id
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700007A")]
	internal bool isDragGhost
	{
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event Action<ReusableCollectionItem> onGeometryChanged
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x29AC5D0", Offset = "0x29AB7D0", VA = "0x1829AC5D0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x29AC730", Offset = "0x29AB930", VA = "0x1829AC730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	internal event Action<ReusableCollectionItem> onDestroy
	{
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x29AC520", Offset = "0x29AB720", VA = "0x1829AC520")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x29AC680", Offset = "0x29AB880", VA = "0x1829AC680")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x29AC4A0", Offset = "0x29AB6A0", VA = "0x1829AC4A0")]
	public ReusableCollectionItem()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010", Slot = "5")]
	public virtual void Init(VisualElement item)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x29AC090", Offset = "0x29AB290", VA = "0x1829AC090", Slot = "6")]
	public virtual void PreAttachElement()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x29ABEE0", Offset = "0x29AB0E0", VA = "0x1829ABEE0", Slot = "7")]
	public virtual void DetachElement()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x29ABEC0", Offset = "0x29AB0C0", VA = "0x1829ABEC0", Slot = "8")]
	public virtual void DestroyElement()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x29AC360", Offset = "0x29AB560", VA = "0x1829AC360", Slot = "9")]
	public virtual void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x29AC160", Offset = "0x29AB360", VA = "0x1829AC160", Slot = "10")]
	public virtual void SetDragGhost(bool dragGhost)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x29AC010", Offset = "0x29AB210", VA = "0x1829AC010", Slot = "11")]
	protected virtual void OnGeometryChanged(GeometryChangedEvent evt)
	{
	}
}
