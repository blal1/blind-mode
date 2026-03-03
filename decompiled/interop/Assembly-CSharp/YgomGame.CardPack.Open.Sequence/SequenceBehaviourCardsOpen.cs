using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.CardPack.Open.Actor;
using YgomGame.CardPack.Open.Widget;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x200155C")]
public class SequenceBehaviourCardsOpen : SequenceBehaviour
{
	[Token(Token = "0x200155D")]
	public class PlayableCommand
	{
		[Token(Token = "0x400CC74")]
		[FieldOffset(Offset = "0x10")]
		public DrawCardData drawCardData;

		[Token(Token = "0x400CC75")]
		[FieldOffset(Offset = "0x18")]
		public CardPackCardActor cardActor;

		[Token(Token = "0x400CC76")]
		[FieldOffset(Offset = "0x20")]
		public PlayableAsset playableAsset;

		[Token(Token = "0x400CC77")]
		[FieldOffset(Offset = "0x28")]
		public bool isLoop;

		[Token(Token = "0x400CC78")]
		[FieldOffset(Offset = "0x2C")]
		private int m_Step;

		[Token(Token = "0x17001426")]
		public bool isDone
		{
			[Token(Token = "0x600840B")]
			[Address(RVA = "0xCDDD00", Offset = "0xCDCF00", VA = "0x180CDDD00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600840C")]
		[Address(RVA = "0xCDDC60", Offset = "0xCDCE60", VA = "0x180CDDC60")]
		public bool Play()
		{
			return default(bool);
		}

		[Token(Token = "0x600840D")]
		[Address(RVA = "0xCDDBC0", Offset = "0xCDCDC0", VA = "0x180CDDBC0")]
		public PlayableCommand Duplicate()
		{
			return null;
		}

		[Token(Token = "0x600840E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public PlayableCommand()
		{
		}
	}

	[Token(Token = "0x200155E")]
	public class OpenCardGroup
	{
		[Token(Token = "0x400CC79")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<CardPackCardActor> m_CardActors;

		[Token(Token = "0x400CC7A")]
		[FieldOffset(Offset = "0x18")]
		private readonly CardPackFoundKeyWidget m_FoundKeyWidget;

		[Token(Token = "0x400CC7B")]
		[FieldOffset(Offset = "0x20")]
		private List<PlayableCommand> m_CommandsStep0;

		[Token(Token = "0x400CC7C")]
		[FieldOffset(Offset = "0x28")]
		private Queue<PlayableCommand> m_CommandsStep1;

		[Token(Token = "0x400CC7D")]
		[FieldOffset(Offset = "0x30")]
		private Queue<PlayableCommand> m_CommandsStep2;

		[Token(Token = "0x400CC7E")]
		[FieldOffset(Offset = "0x38")]
		private List<(int, int)> m_FoundSecrets;

		[Token(Token = "0x400CC7F")]
		[FieldOffset(Offset = "0x40")]
		private int m_Step;

		[Token(Token = "0x400CC80")]
		[FieldOffset(Offset = "0x44")]
		public bool isWaitStep0;

		[Token(Token = "0x17001427")]
		public bool isComplete
		{
			[Token(Token = "0x600840F")]
			[Address(RVA = "0xCDDB30", Offset = "0xCDCD30", VA = "0x180CDDB30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17001428")]
		public int Count
		{
			[Token(Token = "0x6008410")]
			[Address(RVA = "0xCDDAF0", Offset = "0xCDCCF0", VA = "0x180CDDAF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6008411")]
		[Address(RVA = "0xCDD950", Offset = "0xCDCB50", VA = "0x180CDD950")]
		public OpenCardGroup(CardPackFoundKeyWidget foundKeyWidget)
		{
		}

		[Token(Token = "0x6008412")]
		[Address(RVA = "0xCDCB20", Offset = "0xCDBD20", VA = "0x180CDCB20")]
		public bool IsContain(CardPackCardActor cardActor)
		{
			return default(bool);
		}

		[Token(Token = "0x6008413")]
		[Address(RVA = "0xCDCD10", Offset = "0xCDBF10", VA = "0x180CDCD10")]
		public bool IsReversedActor(CardPackCardActor cardActor)
		{
			return default(bool);
		}

		[Token(Token = "0x6008414")]
		[Address(RVA = "0xCDCB80", Offset = "0xCDBD80", VA = "0x180CDCB80")]
		public bool IsPlayingActor(CardPackCardActor cardActor)
		{
			return default(bool);
		}

		[Token(Token = "0x6008415")]
		[Address(RVA = "0xCDCE50", Offset = "0xCDC050", VA = "0x180CDCE50")]
		public bool TryAddCardActor(ActorBindingRefs actorBindRefs, CardPackCardActor cardActor, DrawCardData drawCardData)
		{
			return default(bool);
		}

		[Token(Token = "0x6008416")]
		[Address(RVA = "0xCDD200", Offset = "0xCDC400", VA = "0x180CDD200")]
		public bool Update()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001562")]
	public class OpenCardGroupContainer
	{
		[Token(Token = "0x400CC86")]
		[FieldOffset(Offset = "0x10")]
		private readonly SequenceBehaviourWork m_Work;

		[Token(Token = "0x400CC87")]
		[FieldOffset(Offset = "0x18")]
		private readonly IReadOnlyList<DrawCardData> m_DrawCardDatas;

		[Token(Token = "0x400CC88")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<OpenCardGroup> m_OpenCardGroups;

		[Token(Token = "0x400CC89")]
		[FieldOffset(Offset = "0x28")]
		private OpenCardGroup m_CurrentGroup;

		[Token(Token = "0x400CC8A")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IsAllCardOpened;

		[Token(Token = "0x400CC8B")]
		[FieldOffset(Offset = "0x34")]
		private int m_Step;

		[Token(Token = "0x400CC8C")]
		[FieldOffset(Offset = "0x38")]
		public Action onAddCardEvent;

		[Token(Token = "0x400CC8D")]
		[FieldOffset(Offset = "0x40")]
		public Action onAddCardCompleteEvent;

		[Token(Token = "0x17001429")]
		public bool isInEditGroup
		{
			[Token(Token = "0x6008422")]
			[Address(RVA = "0xC0F710", Offset = "0xC0E910", VA = "0x180C0F710")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700142A")]
		public bool isComplete
		{
			[Token(Token = "0x6008423")]
			[Address(RVA = "0xCDCB10", Offset = "0xCDBD10", VA = "0x180CDCB10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700142B")]
		public bool isAllCardOpened
		{
			[Token(Token = "0x6008424")]
			[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700142C")]
		public IReadOnlyList<DrawCardData> drawCardDatas
		{
			[Token(Token = "0x6008425")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008426")]
		[Address(RVA = "0xCDCA50", Offset = "0xCDBC50", VA = "0x180CDCA50")]
		public OpenCardGroupContainer(SequenceBehaviourWork work, IReadOnlyList<DrawCardData> drawCardDatas)
		{
		}

		[Token(Token = "0x6008427")]
		[Address(RVA = "0xCDBEC0", Offset = "0xCDB0C0", VA = "0x180CDBEC0")]
		private bool IsContainGroup(CardPackCardActor cardActor)
		{
			return default(bool);
		}

		[Token(Token = "0x6008428")]
		[Address(RVA = "0xCDBD30", Offset = "0xCDAF30", VA = "0x180CDBD30")]
		public bool IsCompeteReverseActor(CardPackCardActor cardActor)
		{
			return default(bool);
		}

		[Token(Token = "0x6008429")]
		[Address(RVA = "0xCDC6D0", Offset = "0xCDB8D0", VA = "0x180CDC6D0")]
		public bool TryAddNextCardActor(CardPackCardActor cardActor)
		{
			return default(bool);
		}

		[Token(Token = "0x600842A")]
		[Address(RVA = "0xCDC040", Offset = "0xCDB240", VA = "0x180CDC040")]
		public bool TryAddCardActor(CardPackCardActor cardActor, bool isWaitStep0 = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600842B")]
		[Address(RVA = "0xCDBAB0", Offset = "0xCDACB0", VA = "0x180CDBAB0")]
		public bool AddRemainAllCards()
		{
			return default(bool);
		}

		[Token(Token = "0x600842C")]
		[Address(RVA = "0x9F9620", Offset = "0x9F8820", VA = "0x1809F9620")]
		public void SplitGroup()
		{
		}

		[Token(Token = "0x600842D")]
		[Address(RVA = "0xCDC8D0", Offset = "0xCDBAD0", VA = "0x180CDC8D0")]
		public bool Update()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CC67")]
	[FieldOffset(Offset = "0x20")]
	private readonly int k_Step00_OpenCards;

	[Token(Token = "0x400CC68")]
	[FieldOffset(Offset = "0x24")]
	private readonly int k_Step01_OpenCardsComplete;

	[Token(Token = "0x400CC69")]
	[FieldOffset(Offset = "0x28")]
	private readonly int k_Step02_WaitCardsConfirm;

	[Token(Token = "0x400CC6A")]
	[FieldOffset(Offset = "0x2C")]
	private readonly int k_Step03_WaitEndTimeline;

	[Token(Token = "0x400CC6B")]
	[FieldOffset(Offset = "0x30")]
	private readonly int k_Step04_Finish;

	[Token(Token = "0x400CC6C")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsLast;

	[Token(Token = "0x400CC6D")]
	[FieldOffset(Offset = "0x35")]
	private bool m_SelectedDefaultCursor;

	[Token(Token = "0x400CC6E")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 m_PrevTouchScreenPos;

	[Token(Token = "0x400CC6F")]
	[FieldOffset(Offset = "0x40")]
	private int m_Step;

	[Token(Token = "0x400CC70")]
	[FieldOffset(Offset = "0x44")]
	private bool m_TouchAllOpenTrigger;

	[Token(Token = "0x400CC71")]
	[FieldOffset(Offset = "0x48")]
	private readonly OpenCardGroupContainer m_OpenGroupContainer;

	[Token(Token = "0x400CC72")]
	[FieldOffset(Offset = "0x50")]
	private List<object> m_CardDetailMrks;

	[Token(Token = "0x400CC73")]
	[FieldOffset(Offset = "0x58")]
	private List<object> m_CardDetailPremiums;

	[Token(Token = "0x17001424")]
	protected override bool isAcceptToSkipLoop
	{
		[Token(Token = "0x60083F5")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001425")]
	public IReadOnlyList<DrawCardData> drawCardDatas
	{
		[Token(Token = "0x60083F6")]
		[Address(RVA = "0xCCB130", Offset = "0xCCA330", VA = "0x180CCB130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60083F7")]
	[Address(RVA = "0xCCAE30", Offset = "0xCCA030", VA = "0x180CCAE30")]
	public SequenceBehaviourCardsOpen(SequenceBehaviourWork sequenceBehaviourWork, DrawPackData packData, bool isLast)
	{
	}

	[Token(Token = "0x60083F8")]
	[Address(RVA = "0xCC9460", Offset = "0xCC8660", VA = "0x180CC9460", Slot = "11")]
	protected override void OnBegin()
	{
	}

	[Token(Token = "0x60083F9")]
	[Address(RVA = "0xCCA6A0", Offset = "0xCC98A0", VA = "0x180CCA6A0", Slot = "12")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x60083FA")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	protected override void OnEnd()
	{
	}

	[Token(Token = "0x60083FB")]
	[Address(RVA = "0xCC8D20", Offset = "0xCC7F20", VA = "0x180CC8D20")]
	private void CheckHitDraggingCard(Vector2 prevScreenPos, Vector2 currentScreenPos)
	{
	}

	[Token(Token = "0x60083FC")]
	[Address(RVA = "0xCCAA80", Offset = "0xCC9C80", VA = "0x180CCAA80")]
	private void OpenCardDetail(CardPackCardActor cardActor)
	{
	}

	[Token(Token = "0x60083FD")]
	[Address(RVA = "0xCC92B0", Offset = "0xCC84B0", VA = "0x180CC92B0")]
	private void OnAddCardGroup()
	{
	}

	[Token(Token = "0x60083FE")]
	[Address(RVA = "0xCC9260", Offset = "0xCC8460", VA = "0x180CC9260")]
	private void OnAddCardGroupComplete()
	{
	}

	[Token(Token = "0x60083FF")]
	[Address(RVA = "0xCC9DC0", Offset = "0xCC8FC0", VA = "0x180CC9DC0")]
	private void OnDownTouchArea()
	{
	}

	[Token(Token = "0x6008400")]
	[Address(RVA = "0xCC9D20", Offset = "0xCC8F20", VA = "0x180CC9D20")]
	private void OnDownCardActor(CardPackCardActor cardActor)
	{
	}

	[Token(Token = "0x6008401")]
	[Address(RVA = "0xCC9E80", Offset = "0xCC9080", VA = "0x180CC9E80")]
	private void OnDragTouchArea(SelectionItem.DragStatus dragStatus, Vector2 screenPos)
	{
	}

	[Token(Token = "0x6008402")]
	[Address(RVA = "0xCC9E30", Offset = "0xCC9030", VA = "0x180CC9E30")]
	private void OnDragCardActor(CardPackCardActor cardActor, SelectionItem.DragStatus dragStatus, Vector2 screenPos)
	{
	}

	[Token(Token = "0x6008403")]
	[Address(RVA = "0xCCA5E0", Offset = "0xCC97E0", VA = "0x180CCA5E0")]
	private void OnUpTouchArea()
	{
	}

	[Token(Token = "0x6008404")]
	[Address(RVA = "0xCC9C50", Offset = "0xCC8E50", VA = "0x180CC9C50")]
	private void OnCardActorUp(CardPackCardActor cardActor)
	{
	}

	[Token(Token = "0x6008405")]
	[Address(RVA = "0xCC9C80", Offset = "0xCC8E80", VA = "0x180CC9C80")]
	private void OnClickAllCardOpen()
	{
	}

	[Token(Token = "0x6008406")]
	[Address(RVA = "0xCC9ED0", Offset = "0xCC90D0", VA = "0x180CC9ED0", Slot = "14")]
	protected override void OnInputAccept()
	{
	}

	[Token(Token = "0x6008407")]
	[Address(RVA = "0xCC9C70", Offset = "0xCC8E70", VA = "0x180CC9C70")]
	private void OnCardDetailKey(CardPackCardActor cardActor)
	{
	}

	[Token(Token = "0x6008408")]
	[Address(RVA = "0xCC9BD0", Offset = "0xCC8DD0", VA = "0x180CC9BD0")]
	private void OnCardAcceptKey(CardPackCardActor cardActor)
	{
	}

	[Token(Token = "0x6008409")]
	[Address(RVA = "0xCC9C20", Offset = "0xCC8E20", VA = "0x180CC9C20")]
	private void OnCardActorClick(CardPackCardActor cardActor)
	{
	}

	[Token(Token = "0x600840A")]
	[Address(RVA = "0xCC9320", Offset = "0xCC8520", VA = "0x180CC9320", Slot = "15")]
	public override bool OnBack()
	{
		return default(bool);
	}
}
