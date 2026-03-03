using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x2001122")]
public class SetAccessoryDialog : SelectDialogViewControllerBase<int, List<int>>, IBokeSupported
{
	[Token(Token = "0x400B4E4")]
	private const string PREFAB_PATH_SETACCESSORYDIALOG = "DeckEdit/SetAccessoryDialog";

	[Token(Token = "0x400B4E5")]
	private const string LABEL_TXT_TITLE = "TextTitle";

	[Token(Token = "0x400B4E6")]
	private const string LABEL_TXT_TEXT = "Text";

	[Token(Token = "0x400B4E7")]
	private const string LABEL_EOM_MESSAGEAREA = "MessageArea";

	[Token(Token = "0x400B4E8")]
	private const string LABEL_OBJ_ACCESSORYAREA = "AccessoryArea";

	[Token(Token = "0x400B4E9")]
	private const string LABEL_EOM_ITEM = "Item";

	[Token(Token = "0x400B4EA")]
	private const string LABEL_IMG_IMAGE = "Image";

	[Token(Token = "0x400B4EB")]
	private const string LABEL_BTN_BUTTON = "Button";

	[Token(Token = "0x400B4EC")]
	private const string LABEL_BTN_CANCEL = "ButtonCancel";

	[Token(Token = "0x400B4ED")]
	private const string LABEL_BTN_OK = "ButtonOK";

	[Token(Token = "0x400B4EE")]
	[FieldOffset(Offset = "0xE0")]
	private TMP_Text m_TextTile;

	[Token(Token = "0x400B4EF")]
	[FieldOffset(Offset = "0xE8")]
	private TMP_Text m_TextMessage;

	[Token(Token = "0x400B4F0")]
	[FieldOffset(Offset = "0xF0")]
	private ElementObject m_AccessoryArea;

	[Token(Token = "0x400B4F1")]
	[FieldOffset(Offset = "0xF8")]
	private ElementObjectManager m_ItemEom;

	[Token(Token = "0x400B4F2")]
	[FieldOffset(Offset = "0x100")]
	private SelectionButton m_DesideButton;

	[Token(Token = "0x400B4F3")]
	[FieldOffset(Offset = "0x108")]
	private List<int> m_Settings;

	[Token(Token = "0x400B4F4")]
	[FieldOffset(Offset = "0x110")]
	private int m_Itemid;

	[Token(Token = "0x6006B69")]
	[Address(RVA = "0xB35180", Offset = "0xB34380", VA = "0x180B35180")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x6006B6A")]
	[Address(RVA = "0xB35830", Offset = "0xB34A30", VA = "0x180B35830")]
	public static void Open(int itemId, Action<List<int>> callback)
	{
	}

	[Token(Token = "0x6006B6B")]
	[Address(RVA = "0x540540", Offset = "0x53F740", VA = "0x180540540", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006B6C")]
	[Address(RVA = "0xB35520", Offset = "0xB34720", VA = "0x180B35520", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006B6D")]
	[Address(RVA = "0xB35990", Offset = "0xB34B90", VA = "0x180B35990")]
	private void UpdateItemList()
	{
	}

	[Token(Token = "0x6006B6E")]
	[Address(RVA = "0xB35560", Offset = "0xB34760", VA = "0x180B35560")]
	private void OpenFieldPreview(int fieldId, int objId = 0, int av_baseId = 0)
	{
	}

	[Token(Token = "0x6006B6F")]
	[Address(RVA = "0xB35730", Offset = "0xB34930", VA = "0x180B35730")]
	private void OpenItemPreview(int itemId)
	{
	}

	[Token(Token = "0x6006B70")]
	[Address(RVA = "0xB35100", Offset = "0xB34300", VA = "0x180B35100")]
	private int GetAccessorySetID(int itemID)
	{
		return default(int);
	}

	[Token(Token = "0x6006B71")]
	[Address(RVA = "0xB35080", Offset = "0xB34280", VA = "0x180B35080")]
	private Dictionary<string, object> GetAccessorySetDic(int setID)
	{
		return null;
	}

	[Token(Token = "0x6006B72")]
	[Address(RVA = "0xB36140", Offset = "0xB35340", VA = "0x180B36140")]
	public SetAccessoryDialog()
	{
	}
}
