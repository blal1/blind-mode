using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x2001579")]
public class CardPackCardActor : ActorBase<CardPackCardActor>
{
	[Token(Token = "0x400CD27")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelBackModel;

	[Token(Token = "0x400CD28")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelFrontModel;

	[Token(Token = "0x400CD29")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelFrontPremiereModel;

	[Token(Token = "0x400CD2A")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelRareIconSprite;

	[Token(Token = "0x400CD2B")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelNewIcon;

	[Token(Token = "0x400CD2C")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelPickupIcon;

	[Token(Token = "0x400CD2D")]
	[FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelRarityFrame;

	[Token(Token = "0x400CD2E")]
	[FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelSelectCursor;

	[Token(Token = "0x400CD2F")]
	[FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelSelectCursorFront;

	[Token(Token = "0x400CD30")]
	[FieldOffset(Offset = "0x70")]
	private readonly string k_ELabelSelectCursorBack;

	[Token(Token = "0x400CD31")]
	[FieldOffset(Offset = "0x78")]
	private ActorBindingRefs m_BindingRefs;

	[Token(Token = "0x400CD32")]
	[FieldOffset(Offset = "0x80")]
	private PlayableDirector m_Playable;

	[Token(Token = "0x400CD33")]
	[FieldOffset(Offset = "0x88")]
	private SelectionButton m_Button;

	[Token(Token = "0x400CD34")]
	[FieldOffset(Offset = "0x90")]
	private MeshRenderer m_BackRenderer;

	[Token(Token = "0x400CD35")]
	[FieldOffset(Offset = "0x98")]
	private MeshRenderer m_FrontRenderer;

	[Token(Token = "0x400CD36")]
	[FieldOffset(Offset = "0xA0")]
	private MeshRenderer m_FrontPremireRenderer;

	[Token(Token = "0x400CD37")]
	[FieldOffset(Offset = "0xA8")]
	private SpriteRenderer m_RareIconRenderer;

	[Token(Token = "0x400CD38")]
	[FieldOffset(Offset = "0xB0")]
	private SpriteRenderer m_NewIconRenderer;

	[Token(Token = "0x400CD39")]
	[FieldOffset(Offset = "0xB8")]
	private SpriteRenderer m_PIckupIconRenderer;

	[Token(Token = "0x400CD3A")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject m_RarityFrame;

	[Token(Token = "0x400CD3B")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject m_SelectCursorBack;

	[Token(Token = "0x400CD3C")]
	[FieldOffset(Offset = "0xD0")]
	private GameObject m_SelectCursorFront;

	[Token(Token = "0x400CD3D")]
	[FieldOffset(Offset = "0xD8")]
	private int m_LoadingCnt;

	[Token(Token = "0x1700146F")]
	public int mrk
	{
		[Token(Token = "0x60084F6")]
		[Address(RVA = "0xA2A110", Offset = "0xA29310", VA = "0x180A2A110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60084F7")]
		[Address(RVA = "0xA2A550", Offset = "0xA29750", VA = "0x180A2A550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001470")]
	public int premium
	{
		[Token(Token = "0x60084F8")]
		[Address(RVA = "0x746560", Offset = "0x745760", VA = "0x180746560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60084F9")]
		[Address(RVA = "0xA2A4F0", Offset = "0xA296F0", VA = "0x180A2A4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001471")]
	public bool isPlayingPlayable
	{
		[Token(Token = "0x60084FA")]
		[Address(RVA = "0x62D9F0", Offset = "0x62CBF0", VA = "0x18062D9F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60084FB")]
		[Address(RVA = "0x62DFE0", Offset = "0x62D1E0", VA = "0x18062DFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001472")]
	public PlayableAsset currentPlayableAsset
	{
		[Token(Token = "0x60084FC")]
		[Address(RVA = "0xCD81F0", Offset = "0xCD73F0", VA = "0x180CD81F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001473")]
	public bool isReady
	{
		[Token(Token = "0x60084FD")]
		[Address(RVA = "0xCD8250", Offset = "0xCD7450", VA = "0x180CD8250")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001474")]
	public bool newIconVisible
	{
		[Token(Token = "0x60084FE")]
		[Address(RVA = "0xCD8260", Offset = "0xCD7460", VA = "0x180CD8260")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60084FF")]
		[Address(RVA = "0xCD87C0", Offset = "0xCD79C0", VA = "0x180CD87C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001475")]
	public bool pickupIconVisible
	{
		[Token(Token = "0x6008500")]
		[Address(RVA = "0xCD8290", Offset = "0xCD7490", VA = "0x180CD8290")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008501")]
		[Address(RVA = "0xCD87F0", Offset = "0xCD79F0", VA = "0x180CD87F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001476")]
	public bool frontCursorVisible
	{
		[Token(Token = "0x6008502")]
		[Address(RVA = "0xCD8220", Offset = "0xCD7420", VA = "0x180CD8220")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008503")]
		[Address(RVA = "0xCD8790", Offset = "0xCD7990", VA = "0x180CD8790")]
		set
		{
		}
	}

	[Token(Token = "0x17001477")]
	public bool backCursorVisible
	{
		[Token(Token = "0x6008504")]
		[Address(RVA = "0xCD81C0", Offset = "0xCD73C0", VA = "0x180CD81C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008505")]
		[Address(RVA = "0xCD8760", Offset = "0xCD7960", VA = "0x180CD8760")]
		set
		{
		}
	}

	[Token(Token = "0x17001478")]
	public bool rarityFrameVisible
	{
		[Token(Token = "0x6008506")]
		[Address(RVA = "0xCD82C0", Offset = "0xCD74C0", VA = "0x180CD82C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008507")]
		[Address(RVA = "0xCD8820", Offset = "0xCD7A20", VA = "0x180CD8820")]
		set
		{
		}
	}

	[Token(Token = "0x17001479")]
	public SelectionButton button
	{
		[Token(Token = "0x6008508")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x140000B1")]
	public event Action<CardPackCardActor> onAcceptKeyEvent
	{
		[Token(Token = "0x6008509")]
		[Address(RVA = "0xCD7D40", Offset = "0xCD6F40", VA = "0x180CD7D40")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600850A")]
		[Address(RVA = "0xCD82E0", Offset = "0xCD74E0", VA = "0x180CD82E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000B2")]
	public event Action<CardPackCardActor> onDetailKeyEvent
	{
		[Token(Token = "0x600850B")]
		[Address(RVA = "0xCD7E00", Offset = "0xCD7000", VA = "0x180CD7E00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600850C")]
		[Address(RVA = "0xCD83A0", Offset = "0xCD75A0", VA = "0x180CD83A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000B3")]
	public event Action<CardPackCardActor, SelectionItem.DragStatus, Vector2> onDragEvent
	{
		[Token(Token = "0x600850D")]
		[Address(RVA = "0xCD7EC0", Offset = "0xCD70C0", VA = "0x180CD7EC0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600850E")]
		[Address(RVA = "0xCD8460", Offset = "0xCD7660", VA = "0x180CD8460")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000B4")]
	public event Action<CardPackCardActor> onPointerDownEvent
	{
		[Token(Token = "0x600850F")]
		[Address(RVA = "0xCD8040", Offset = "0xCD7240", VA = "0x180CD8040")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6008510")]
		[Address(RVA = "0xCD85E0", Offset = "0xCD77E0", VA = "0x180CD85E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000B5")]
	public event Action<CardPackCardActor> onPointerUpEvent
	{
		[Token(Token = "0x6008511")]
		[Address(RVA = "0xCD8100", Offset = "0xCD7300", VA = "0x180CD8100")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6008512")]
		[Address(RVA = "0xCD86A0", Offset = "0xCD78A0", VA = "0x180CD86A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000B6")]
	public event Action<CardPackCardActor> onPointerClickEvent
	{
		[Token(Token = "0x6008513")]
		[Address(RVA = "0xCD7F80", Offset = "0xCD7180", VA = "0x180CD7F80")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6008514")]
		[Address(RVA = "0xCD8520", Offset = "0xCD7720", VA = "0x180CD8520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6008515")]
	[Address(RVA = "0xCD7840", Offset = "0xCD6A40", VA = "0x180CD7840")]
	public static CardPackCardActor Create(ElementObjectManager eom, ActorBindingRefs bindingRefs)
	{
		return null;
	}

	[Token(Token = "0x6008516")]
	[Address(RVA = "0xCD7100", Offset = "0xCD6300", VA = "0x180CD7100", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6008517")]
	[Address(RVA = "0xCD6E00", Offset = "0xCD6000", VA = "0x180CD6E00")]
	public void Binding(int mrk, int premium)
	{
	}

	[Token(Token = "0x6008518")]
	[Address(RVA = "0xCD7950", Offset = "0xCD6B50", VA = "0x180CD7950")]
	public void PlayPlayable(PlayableAsset playableAsset, DirectorWrapMode wrapMode = DirectorWrapMode.None)
	{
	}

	[Token(Token = "0x6008519")]
	[Address(RVA = "0xCD7930", Offset = "0xCD6B30", VA = "0x180CD7930")]
	private void OnBeginPlayable(PlayableDirector playable)
	{
	}

	[Token(Token = "0x600851A")]
	[Address(RVA = "0xCD7940", Offset = "0xCD6B40", VA = "0x180CD7940")]
	private void OnEndPlayable(PlayableDirector playable)
	{
	}

	[Token(Token = "0x600851B")]
	[Address(RVA = "0xCD7B70", Offset = "0xCD6D70", VA = "0x180CD7B70")]
	public CardPackCardActor()
	{
	}
}
