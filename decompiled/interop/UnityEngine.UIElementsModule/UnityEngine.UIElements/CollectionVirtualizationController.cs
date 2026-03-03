using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000060")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal abstract class CollectionVirtualizationController
{
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x10")]
	protected readonly ScrollView m_ScrollView;

	[Token(Token = "0x1700006A")]
	public abstract int firstVisibleIndex
	{
		[Token(Token = "0x600033C")]
		get;
		[Token(Token = "0x600033D")]
		protected set;
	}

	[Token(Token = "0x1700006B")]
	public abstract int visibleItemCount
	{
		[Token(Token = "0x600033E")]
		get;
	}

	[Token(Token = "0x1700006C")]
	public abstract IEnumerable<ReusableCollectionItem> activeItems
	{
		[Token(Token = "0x600034A")]
		get;
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	protected CollectionVirtualizationController(ScrollView scrollView)
	{
	}

	[Token(Token = "0x6000340")]
	public abstract void Refresh(bool rebuild);

	[Token(Token = "0x6000341")]
	public abstract void ScrollToItem(int id);

	[Token(Token = "0x6000342")]
	public abstract void Resize(Vector2 size);

	[Token(Token = "0x6000343")]
	public abstract void OnScroll(Vector2 offset);

	[Token(Token = "0x6000344")]
	public abstract int GetIndexFromPosition(Vector2 position);

	[Token(Token = "0x6000345")]
	public abstract float GetExpectedItemHeight(int index);

	[Token(Token = "0x6000346")]
	public abstract float GetExpectedContentHeight();

	[Token(Token = "0x6000347")]
	public abstract void OnFocusIn(VisualElement leafTarget);

	[Token(Token = "0x6000348")]
	public abstract void OnFocusOut(VisualElement willFocus);

	[Token(Token = "0x6000349")]
	public abstract void UpdateBackground();

	[Token(Token = "0x600034B")]
	internal abstract void StartDragItem(ReusableCollectionItem item);

	[Token(Token = "0x600034C")]
	internal abstract void EndDrag(int dropIndex);

	[Token(Token = "0x600034D")]
	public abstract void UnbindAll();
}
