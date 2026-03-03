using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000622")]
public class ToggleGroupWidget : ElementWidgetBase
{
	[Token(Token = "0x4001DAE")]
	[FieldOffset(Offset = "0x20")]
	private readonly ToggleWidget[] m_ChildToggles;

	[Token(Token = "0x4001DAF")]
	[FieldOffset(Offset = "0x28")]
	private int m_CurrentIdx;

	[Token(Token = "0x1700050D")]
	public int currentIdx
	{
		[Token(Token = "0x600286F")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x6B2220", Offset = "0x6B1420", VA = "0x1806B2220")]
		private set
		{
		}
	}

	[Token(Token = "0x1700050E")]
	public ToggleWidget currentToggle
	{
		[Token(Token = "0x6002871")]
		[Address(RVA = "0x6B2140", Offset = "0x6B1340", VA = "0x1806B2140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700050F")]
	public bool selectChildOnCurrentSelected
	{
		[Token(Token = "0x6002872")]
		[Address(RVA = "0x66A190", Offset = "0x669390", VA = "0x18066A190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002873")]
		[Address(RVA = "0x6B2310", Offset = "0x6B1510", VA = "0x1806B2310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000510")]
	public IReadOnlyList<ToggleWidget> childToggles
	{
		[Token(Token = "0x6002874")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000037")]
	public event Action<int> onChangeIdx
	{
		[Token(Token = "0x6002875")]
		[Address(RVA = "0x6B2090", Offset = "0x6B1290", VA = "0x1806B2090")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6002876")]
		[Address(RVA = "0x6B2170", Offset = "0x6B1370", VA = "0x1806B2170")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6002877")]
	[Address(RVA = "0x6B1ED0", Offset = "0x6B10D0", VA = "0x1806B1ED0")]
	public ToggleGroupWidget(ElementObjectManager eom, ToggleWidget[] toggles, int defaultIdx = 0)
	{
	}

	[Token(Token = "0x6002878")]
	[Address(RVA = "0x6B1CF0", Offset = "0x6B0EF0", VA = "0x1806B1CF0")]
	public void SelectCurrentToggle(bool initializeSelection = false)
	{
	}

	[Token(Token = "0x6002879")]
	[Address(RVA = "0x6B19D0", Offset = "0x6B0BD0", VA = "0x1806B19D0")]
	public bool MoveIdx(int idx, bool isLoop = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600287A")]
	[Address(RVA = "0x6B1960", Offset = "0x6B0B60", VA = "0x1806B1960")]
	public bool MoveIdxNext(bool isLoop = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600287B")]
	[Address(RVA = "0x6B18F0", Offset = "0x6B0AF0", VA = "0x1806B18F0")]
	public bool MoveIdxBack(bool isLoop = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600287C")]
	[Address(RVA = "0x6B1C60", Offset = "0x6B0E60", VA = "0x1806B1C60")]
	public void ResetIdx(int idx)
	{
	}

	[Token(Token = "0x600287D")]
	[Address(RVA = "0x6B1BD0", Offset = "0x6B0DD0", VA = "0x1806B1BD0")]
	public void ResetAllOff()
	{
	}

	[Token(Token = "0x600287E")]
	[Address(RVA = "0x6B1A30", Offset = "0x6B0C30", VA = "0x1806B1A30")]
	private void OnChangedToggleValue(int idx, bool value)
	{
	}

	[Token(Token = "0x600287F")]
	[Address(RVA = "0x6B1D40", Offset = "0x6B0F40", VA = "0x1806B1D40")]
	public void UpdateDefaultItem()
	{
	}
}
