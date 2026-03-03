using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using YgomGame.CardPack.Open.Widget;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x2001577")]
public class CardPackRootActorContainer : ActorContainerBase<CardPackRootActorContainer>
{
	[Token(Token = "0x400CD16")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelBgRoot;

	[Token(Token = "0x400CD17")]
	private const string k_ELabelInfoGrp = "InfoGrp";

	[Token(Token = "0x400CD18")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelPackGrp;

	[Token(Token = "0x400CD19")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelCardGrp;

	[Token(Token = "0x400CD1A")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelReflectionRenderCanvas;

	[Token(Token = "0x400CD1B")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelReflectionRenderImage;

	[Token(Token = "0x400CD1C")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelFoundKeyTotal;

	[Token(Token = "0x400CD1D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ActorBindingRefs m_ActorBindingRefs;

	[Token(Token = "0x400CD1E")]
	[FieldOffset(Offset = "0x60")]
	private PlayableDirector m_Playable;

	[Token(Token = "0x400CD1F")]
	[FieldOffset(Offset = "0x68")]
	private ElementObjectManager m_Root3DEom;

	[Token(Token = "0x400CD20")]
	[FieldOffset(Offset = "0x70")]
	private ElementObjectManager m_RootUIEom;

	[Token(Token = "0x17001462")]
	public PlayableDirector playable
	{
		[Token(Token = "0x60084D9")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001463")]
	public ActorBindingRefs bindingRefs
	{
		[Token(Token = "0x60084DA")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001464")]
	public CardPackBgActorContainer bgContainer
	{
		[Token(Token = "0x60084DB")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60084DC")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001465")]
	public CardPackInfoActorContainer infoContainer
	{
		[Token(Token = "0x60084DD")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60084DE")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001466")]
	public CardPackPackActorContainer packContainer
	{
		[Token(Token = "0x60084DF")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60084E0")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001467")]
	public CardPackCardActorContainer cardContainer
	{
		[Token(Token = "0x60084E1")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60084E2")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001468")]
	public CardPackFoundKeyWidget foundKeyWidget
	{
		[Token(Token = "0x60084E3")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60084E4")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001469")]
	public CardPackCanvasActorContainer canvasContainer
	{
		[Token(Token = "0x60084E5")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60084E6")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700146A")]
	public bool isPlaingPlayable
	{
		[Token(Token = "0x60084E7")]
		[Address(RVA = "0xCDA3F0", Offset = "0xCD95F0", VA = "0x180CDA3F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700146B")]
	public bool isLoopPlayable
	{
		[Token(Token = "0x60084E8")]
		[Address(RVA = "0xCDA3D0", Offset = "0xCD95D0", VA = "0x180CDA3D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60084E9")]
		[Address(RVA = "0xCDA550", Offset = "0xCD9750", VA = "0x180CDA550")]
		set
		{
		}
	}

	[Token(Token = "0x1700146C")]
	public bool isPausePlayable
	{
		[Token(Token = "0x60084EA")]
		[Address(RVA = "0xCDA3E0", Offset = "0xCD95E0", VA = "0x180CDA3E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60084EB")]
		[Address(RVA = "0xCDA560", Offset = "0xCD9760", VA = "0x180CDA560")]
		set
		{
		}
	}

	[Token(Token = "0x1700146D")]
	public Canvas reflectionRenderCanvas
	{
		[Token(Token = "0x60084EC")]
		[Address(RVA = "0xCDA4B0", Offset = "0xCD96B0", VA = "0x180CDA4B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700146E")]
	public RawImage reflectionRenderImage
	{
		[Token(Token = "0x60084ED")]
		[Address(RVA = "0xCDA500", Offset = "0xCD9700", VA = "0x180CDA500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60084EE")]
	[Address(RVA = "0xCD9F90", Offset = "0xCD9190", VA = "0x180CD9F90")]
	public static CardPackRootActorContainer Create(ElementObjectManager rootEom, ElementObjectManager root3DEom, ElementObjectManager rootUIEom)
	{
		return null;
	}

	[Token(Token = "0x60084EF")]
	[Address(RVA = "0xCD9BC0", Offset = "0xCD8DC0", VA = "0x180CD9BC0", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x60084F0")]
	[Address(RVA = "0xCDA030", Offset = "0xCD9230", VA = "0x180CDA030")]
	public void Hide()
	{
	}

	[Token(Token = "0x60084F1")]
	[Address(RVA = "0xCDA170", Offset = "0xCD9370", VA = "0x180CDA170")]
	public void Show()
	{
	}

	[Token(Token = "0x60084F2")]
	[Address(RVA = "0xCDA120", Offset = "0xCD9320", VA = "0x180CDA120")]
	public void PlayPlayable(PlayableAsset playableAsset)
	{
	}

	[Token(Token = "0x60084F3")]
	[Address(RVA = "0xCD9A80", Offset = "0xCD8C80", VA = "0x180CD9A80", Slot = "5")]
	public override void Cleanup(bool keepInfo = false)
	{
	}

	[Token(Token = "0x60084F4")]
	[Address(RVA = "0xCDA260", Offset = "0xCD9460", VA = "0x180CDA260")]
	public CardPackRootActorContainer()
	{
	}
}
