using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Prize.TurnOverPrize;

[Token(Token = "0x2000BBC")]
public class TurnOverPrizeViewerViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000BBD")]
	private class InfoBehaviour : IBehaviour
	{
		[Token(Token = "0x40097F6")]
		private const string k_ELabel_PackTemplate = "PackGroup/PackTemplate";

		[Token(Token = "0x40097F7")]
		private const string k_ELabel_Entity_PackImage = "PackImage";

		[Token(Token = "0x40097F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TurnOverPrizeViewerViewController m_Owner;

		[Token(Token = "0x40097F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ElementObjectManager m_PackPref;

		[Token(Token = "0x40097FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<string> m_InfoSheetEntries;

		[Token(Token = "0x40097FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<GameObject, (Image packImage, SelectionButton button)> m_WidgetMap;

		[Token(Token = "0x6004783")]
		[Address(RVA = "0x8FD980", Offset = "0x8FCB80", VA = "0x1808FD980")]
		public InfoBehaviour(TurnOverPrizeViewerViewController owner)
		{
		}

		[Token(Token = "0x6004784")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
		public void NotificationStackEntry()
		{
		}

		[Token(Token = "0x6004785")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
		public void NotificationStackRemove()
		{
		}

		[Token(Token = "0x6004786")]
		[Address(RVA = "0x8FD5C0", Offset = "0x8FC7C0", VA = "0x1808FD5C0", Slot = "5")]
		public void OnCreatedView(ElementObjectManager view)
		{
		}

		[Token(Token = "0x6004787")]
		[Address(RVA = "0x8FD100", Offset = "0x8FC300", VA = "0x1808FD100", Slot = "6")]
		public void OnAssignEntity(GameObject locator)
		{
		}

		[Token(Token = "0x6004788")]
		[Address(RVA = "0x8FD640", Offset = "0x8FC840", VA = "0x1808FD640", Slot = "7")]
		public void OnStart()
		{
		}

		[Token(Token = "0x6004789")]
		[Address(RVA = "0x8FD260", Offset = "0x8FC460", VA = "0x1808FD260")]
		private void OnClick(int dataIdx)
		{
		}
	}

	[Token(Token = "0x2000BC0")]
	private class ResultBehaviour : IBehaviour
	{
		[Token(Token = "0x4009800")]
		private const string k_ELabel_PackImageTemplate = "PackGroup/PackImageTemplate";

		[Token(Token = "0x4009801")]
		private const string k_ELabel_CardImageTemplate = "PackGroup/CardImageTemplate";

		[Token(Token = "0x4009802")]
		private const string k_ELabel_Entity_PackImageHolder = "PackImageHolder";

		[Token(Token = "0x4009803")]
		private const string k_ELabel_Entity_CardImageHolder = "CardImageHolder";

		[Token(Token = "0x4009804")]
		private const string k_TLabelPackDefault = "Default";

		[Token(Token = "0x4009805")]
		private const string k_TLabelPackShadow = "Shadow";

		[Token(Token = "0x4009806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TurnOverPrizeViewerViewController m_Owner;

		[Token(Token = "0x4009807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Image m_PackImagePref;

		[Token(Token = "0x4009808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RawImage m_CardImagePref;

		[Token(Token = "0x4009809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<GameObject, (Image packImage, RawImage cardImage, SelectionButton packButton, SelectionButton cardButton)> m_WidgetMap;

		[Token(Token = "0x400980A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<int> m_CardDetailMrks;

		[Token(Token = "0x400980B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> m_CardDetailStyles;

		[Token(Token = "0x400980C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<int, int> m_CardDetailPosMap;

		[Token(Token = "0x600478E")]
		[Address(RVA = "0x90E990", Offset = "0x90DB90", VA = "0x18090E990")]
		public ResultBehaviour(TurnOverPrizeViewerViewController owner)
		{
		}

		[Token(Token = "0x600478F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
		public void NotificationStackEntry()
		{
		}

		[Token(Token = "0x6004790")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
		public void NotificationStackRemove()
		{
		}

		[Token(Token = "0x6004791")]
		[Address(RVA = "0x90DA60", Offset = "0x90CC60", VA = "0x18090DA60", Slot = "5")]
		public void OnCreatedView(ElementObjectManager view)
		{
		}

		[Token(Token = "0x6004792")]
		[Address(RVA = "0x90D5F0", Offset = "0x90C7F0", VA = "0x18090D5F0", Slot = "6")]
		public void OnAssignEntity(GameObject locator)
		{
		}

		[Token(Token = "0x6004793")]
		[Address(RVA = "0x90DB20", Offset = "0x90CD20", VA = "0x18090DB20", Slot = "7")]
		public void OnStart()
		{
		}

		[Token(Token = "0x6004794")]
		[Address(RVA = "0x90E830", Offset = "0x90DA30", VA = "0x18090E830")]
		public void PackToDefault(Image packImage)
		{
		}

		[Token(Token = "0x6004795")]
		[Address(RVA = "0x90E8E0", Offset = "0x90DAE0", VA = "0x18090E8E0")]
		public void PackToShadow(Image packImage)
		{
		}

		[Token(Token = "0x6004796")]
		[Address(RVA = "0x90D820", Offset = "0x90CA20", VA = "0x18090D820")]
		private void OnClick(int dataIdx)
		{
		}
	}

	[Token(Token = "0x2000BC3")]
	private interface IBehaviour
	{
		[Token(Token = "0x600479D")]
		void NotificationStackEntry();

		[Token(Token = "0x600479E")]
		void OnCreatedView(ElementObjectManager view);

		[Token(Token = "0x600479F")]
		void OnAssignEntity(GameObject locator);

		[Token(Token = "0x60047A0")]
		void OnStart();

		[Token(Token = "0x60047A1")]
		void NotificationStackRemove();
	}

	[Token(Token = "0x2000BC4")]
	public enum Mode
	{
		[Token(Token = "0x4009813")]
		Info,
		[Token(Token = "0x4009814")]
		Result
	}

	[Token(Token = "0x40097E6")]
	private const string k_VCPath = "Prize/TurnOverPrize/TurnOverPrizeViewer";

	[Token(Token = "0x40097E7")]
	private const string k_ArgKeyPrizeId = "prizeId";

	[Token(Token = "0x40097E8")]
	private const string k_ArgKeyMode = "mode";

	[Token(Token = "0x40097E9")]
	internal const string k_ArgKeyTitle = "title";

	[Token(Token = "0x40097EA")]
	internal const string k_ArgKeyDesc = "desc";

	[Token(Token = "0x40097EB")]
	private const string k_VLabelFormat_Info = "InfoView_{0:D2}";

	[Token(Token = "0x40097EC")]
	private const string k_VLabelFormat_Result = "ResultView_{0:D2}";

	[Token(Token = "0x40097ED")]
	private const string k_ELabelTitle = "TitleText";

	[Token(Token = "0x40097EE")]
	private const string k_ELabelDesc = "DescText";

	[Token(Token = "0x40097EF")]
	private const string k_ELabelPackGroup = "PackGroup";

	[Token(Token = "0x40097F0")]
	private const string k_ELabelPackGroup_LocaterFormat = "Locater{0}";

	[Token(Token = "0x40097F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Sprite m_CoverSprite;

	[Token(Token = "0x40097F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int m_ShopId;

	[Token(Token = "0x40097F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<object> m_PrizeDatas;

	[Token(Token = "0x40097F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private IBehaviour m_Behaviour;

	[Token(Token = "0x40097F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private GameObject[] m_Entities;

	[Token(Token = "0x170009AB")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6004777")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170009AC")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6004778")]
		[Address(RVA = "0x912830", Offset = "0x911A30", VA = "0x180912830", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004779")]
	[Address(RVA = "0x9126D0", Offset = "0x9118D0", VA = "0x1809126D0")]
	public static void OpenAsInfo(int prizeId = 1, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600477A")]
	[Address(RVA = "0x9126E0", Offset = "0x9118E0", VA = "0x1809126E0")]
	public static void OpenAsResult(int prizeId = 1, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600477B")]
	[Address(RVA = "0x911DB0", Offset = "0x910FB0", VA = "0x180911DB0")]
	private static void InnerOpen(Mode mode, int prizeId, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600477C")]
	[Address(RVA = "0x911EF0", Offset = "0x9110F0", VA = "0x180911EF0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600477D")]
	[Address(RVA = "0x9123C0", Offset = "0x9115C0", VA = "0x1809123C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600477E")]
	[Address(RVA = "0x911B60", Offset = "0x910D60", VA = "0x180911B60")]
	private void CreateEntities()
	{
	}

	[Token(Token = "0x600477F")]
	[Address(RVA = "0x912700", Offset = "0x911900", VA = "0x180912700")]
	private void Start()
	{
	}

	[Token(Token = "0x6004780")]
	[Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004781")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public TurnOverPrizeViewerViewController()
	{
	}
}
