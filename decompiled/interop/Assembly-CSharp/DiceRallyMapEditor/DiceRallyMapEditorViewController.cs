using Il2CppDummyDll;
using UnityEngine;
using YgomGame.DiceRally;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace DiceRallyMapEditor;

[Token(Token = "0x200013B")]
public class DiceRallyMapEditorViewController : BaseMenuViewController
{
	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private int mapWidth;

	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private int mapHeight;

	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string EOM_STOCK_AREA;

	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string EOM_MAP_AREA;

	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string EOM_MAPTIP_COUNT;

	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0xF0")]
	private ElementObjectManager m_StockEOM;

	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0xF8")]
	private ElementObjectManager m_MapEOM;

	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x100")]
	private MaptipWidgetManager m_MaptipManager;

	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x108")]
	private DiceRallySetting m_DiceRallySetting;

	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x110")]
	private SelectionArea m_SelectionArea;

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x9CC450", Offset = "0x9CB650", VA = "0x1809CC450", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x9CC4E0", Offset = "0x9CB6E0", VA = "0x1809CC4E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x9CC3A0", Offset = "0x9CB5A0", VA = "0x1809CC3A0")]
	private bool DragStarter(Vector2 start, Vector2 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x9CD1B0", Offset = "0x9CC3B0", VA = "0x1809CD1B0")]
	private void OnDrag(SelectionItem.DragStatus status, Vector2 pos)
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x9CD330", Offset = "0x9CC530", VA = "0x1809CD330")]
	public DiceRallyMapEditorViewController()
	{
	}
}
