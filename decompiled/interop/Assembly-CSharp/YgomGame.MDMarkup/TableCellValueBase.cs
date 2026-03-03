using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C9F")]
public abstract class TableCellValueBase<ChildTableType> : IMDMarkupTableCellValueContent, IMDMarkupTableContent, IMDMarkupSourceRequireTextData, IMDMarkupId, IMDMarkupOwnedId where ChildTableType : class, IMDMarkupTableDataContent, new()
{
	[Token(Token = "0x4009B9B")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[EnumString(typeof(MDMarkupDef.TableCellValueType))]
	public string type;

	[Token(Token = "0x4009B9C")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public TextAlignmentOptions alignment;

	[Token(Token = "0x4009B9D")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public GlobalTextData text;

	[Token(Token = "0x4009B9E")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public string imagePath;

	[Token(Token = "0x4009B9F")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public float overrideHeight;

	[Token(Token = "0x4009BA0")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public float overrideWidth;

	[Token(Token = "0x4009BA1")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool usePrefferedSize;

	[Token(Token = "0x4009BA2")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool detailEnabled;

	[Token(Token = "0x4009BA3")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int mrk;

	[Token(Token = "0x4009BA4")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int premiere;

	[Token(Token = "0x4009BA5")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public MDMarkupDef.CardSize cardSize;

	[Token(Token = "0x4009BA6")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private int rarity;

	[Token(Token = "0x4009BA7")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private int limitReg;

	[Token(Token = "0x4009BA8")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private int prevLimitReg;

	[Token(Token = "0x4009BA9")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int limitRegId;

	[Token(Token = "0x4009BAA")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool limitNoneVisible;

	[Token(Token = "0x4009BAB")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool isPeriod;

	[Token(Token = "0x4009BAC")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int itemCategory;

	[Token(Token = "0x4009BAD")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int itemId;

	[Token(Token = "0x4009BAE")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public MDMarkupDef.ItemSize itemSize;

	[Token(Token = "0x4009BAF")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public MDMarkupBannerContext banner;

	[Token(Token = "0x4009BB0")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public string link;

	[Token(Token = "0x4009BB1")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public bool interactable;

	[Token(Token = "0x4009BB2")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public GlobalTextData desc;

	[Token(Token = "0x4009BB3")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public MDMarkupDef.ButtonStyle buttonStyle;

	[Token(Token = "0x4009BB4")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public ChildTableType childTable;

	[Token(Token = "0x4009BB6")]
	[FieldOffset(Offset = "0x0")]
	private bool m_RarityVisible;

	[Token(Token = "0x4009BB7")]
	[FieldOffset(Offset = "0x0")]
	private int m_Rarity;

	[Token(Token = "0x4009BB8")]
	[FieldOffset(Offset = "0x0")]
	private bool m_LimitRegVisible;

	[Token(Token = "0x4009BB9")]
	[FieldOffset(Offset = "0x0")]
	private int m_LimitReg;

	[Token(Token = "0x4009BBA")]
	[FieldOffset(Offset = "0x0")]
	private bool m_PrevLimitRegVisible;

	[Token(Token = "0x4009BBB")]
	[FieldOffset(Offset = "0x0")]
	private int m_PrevLimitReg;

	[Token(Token = "0x17000AB7")]
	public Sprite imageSprite
	{
		[Token(Token = "0x6004C8E")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004C8F")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000AB8")]
	public MDMarkupDef.TableCellValueType valueType
	{
		[Token(Token = "0x6004C90")]
		get
		{
			return default(MDMarkupDef.TableCellValueType);
		}
		[Token(Token = "0x6004C91")]
		set
		{
		}
	}

	[Token(Token = "0x17000AB9")]
	public string id
	{
		[Token(Token = "0x6004C92")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ABA")]
	private TextAlignmentOptions YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002Ealignment
	{
		[Token(Token = "0x6004C93")]
		get
		{
			return default(TextAlignmentOptions);
		}
		[Token(Token = "0x6004C94")]
		set
		{
		}
	}

	[Token(Token = "0x17000ABB")]
	private GlobalTextData YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002Etext
	{
		[Token(Token = "0x6004C95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ABC")]
	private string YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EimagePath
	{
		[Token(Token = "0x6004C96")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004C97")]
		set
		{
		}
	}

	[Token(Token = "0x17000ABD")]
	private float YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EoverrideHeight
	{
		[Token(Token = "0x6004C98")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000ABE")]
	private float YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EoverrideWidth
	{
		[Token(Token = "0x6004C99")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000ABF")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EusePrefferedSize
	{
		[Token(Token = "0x6004C9A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AC0")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EdetailEnabled
	{
		[Token(Token = "0x6004C9B")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AC1")]
	private int YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002Emrk
	{
		[Token(Token = "0x6004C9C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004C9D")]
		set
		{
		}
	}

	[Token(Token = "0x17000AC2")]
	private int YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002Epremiere
	{
		[Token(Token = "0x6004C9E")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000AC3")]
	private MDMarkupDef.CardSize YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EcardSize
	{
		[Token(Token = "0x6004C9F")]
		get
		{
			return default(MDMarkupDef.CardSize);
		}
	}

	[Token(Token = "0x17000AC4")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002ErarityVisible
	{
		[Token(Token = "0x6004CA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AC5")]
	private int YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002Erarity
	{
		[Token(Token = "0x6004CA1")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000AC6")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002ElimitVisible
	{
		[Token(Token = "0x6004CA2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AC7")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002ElimitNoneVisible
	{
		[Token(Token = "0x6004CA3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AC8")]
	private int YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002ElimitRegId
	{
		[Token(Token = "0x6004CA4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000AC9")]
	private int YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002ElimitStatus
	{
		[Token(Token = "0x6004CA5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000ACA")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EprevLimitVisible
	{
		[Token(Token = "0x6004CA6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000ACB")]
	private int YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EprevLimitStatus
	{
		[Token(Token = "0x6004CA7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000ACC")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EisPeriod
	{
		[Token(Token = "0x6004CA8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000ACD")]
	private int YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EitemCategory
	{
		[Token(Token = "0x6004CA9")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000ACE")]
	private int YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EitemId
	{
		[Token(Token = "0x6004CAA")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000ACF")]
	private MDMarkupDef.ItemSize YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EitemSize
	{
		[Token(Token = "0x6004CAB")]
		get
		{
			return default(MDMarkupDef.ItemSize);
		}
	}

	[Token(Token = "0x17000AD0")]
	private MDMarkupBannerContext YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002Ebanner
	{
		[Token(Token = "0x6004CAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AD1")]
	private string YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002Elink
	{
		[Token(Token = "0x6004CAD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AD2")]
	private bool YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002Einteractable
	{
		[Token(Token = "0x6004CAE")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AD3")]
	private GlobalTextData YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002Edesc
	{
		[Token(Token = "0x6004CAF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AD4")]
	private MDMarkupDef.ButtonStyle YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EbuttonStyle
	{
		[Token(Token = "0x6004CB0")]
		get
		{
			return default(MDMarkupDef.ButtonStyle);
		}
	}

	[Token(Token = "0x17000AD5")]
	private IMDMarkupTableDataContent YgomGame_002EMDMarkup_002EIMDMarkupTableCellValueContent_002EchildTable
	{
		[Token(Token = "0x6004CB1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004CB2")]
	public object ExportJsonObj()
	{
		return null;
	}

	[Token(Token = "0x6004CB3")]
	public void ImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004CB4")]
	public virtual void CollectContentsIdMap(Dictionary<string, IMDMarkupId> destMap)
	{
	}

	[Token(Token = "0x6004CB5")]
	public virtual void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004CB6")]
	public void OnFormatByArgsModifier(object[] formatParams)
	{
	}

	[Token(Token = "0x6004CB7")]
	private (bool, int) UnpackMultiFeatureValue(int packedValue, int baseValue)
	{
		return default((bool, int));
	}

	[Token(Token = "0x6004CB8")]
	protected TableCellValueBase()
	{
	}
}
