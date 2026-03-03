using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.DiceRally;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

[Token(Token = "0x2000038")]
public class GoalInfomationWidget : MonoBehaviour
{
	[Token(Token = "0x2000039")]
	public enum ViewType
	{
		[Token(Token = "0x4000111")]
		Single,
		[Token(Token = "0x4000112")]
		Double,
		[Token(Token = "0x4000113")]
		NoReward
	}

	[Token(Token = "0x200003A")]
	private class FeatureReward
	{
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x10")]
		public SelectionButton imageButton;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x18")]
		public ExtendedTextMeshProUGUI lapInfo;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x20")]
		public GameObject rewardImage;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x28")]
		public ExtendedTextMeshProUGUI rewardInfo;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public FeatureReward()
		{
		}
	}

	[Token(Token = "0x200003B")]
	private class NextReward
	{
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x10")]
		public ExtendedTextMeshProUGUI lapInfo;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x18")]
		public GameObject rewardImage;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x20")]
		public ExtendedTextMeshProUGUI rewardInfo;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public NextReward()
		{
		}
	}

	[Token(Token = "0x200003C")]
	private class SingleViewField
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x10")]
		public ExtendedTextMeshProUGUI goalInfo;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x18")]
		public FeatureReward featureReward;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x3E3DD0", Offset = "0x3E2FD0", VA = "0x1803E3DD0")]
		public SingleViewField()
		{
		}
	}

	[Token(Token = "0x200003D")]
	private class DoubleViewField
	{
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		public ExtendedTextMeshProUGUI goalInfo;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		public NextReward nextReward;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		public FeatureReward featureReward;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x3DB710", Offset = "0x3DA910", VA = "0x1803DB710")]
		public DoubleViewField()
		{
		}
	}

	[Token(Token = "0x200003E")]
	private class NoRewardViewField
	{
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x10")]
		public ExtendedTextMeshProUGUI goalInfo;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x18")]
		public ExtendedTextMeshProUGUI lapInfo;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public NoRewardViewField()
		{
		}
	}

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x20")]
	private readonly string GOB_SINGLE_LABEL;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x28")]
	private readonly string GOB_DOUBLE_LABEL;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x30")]
	private readonly string GOB_NOREWARD_LABEL;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x38")]
	private readonly string TXT_GOALINFO_LABEL;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x40")]
	private readonly string TXT_LAPINFO_LABEL;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x48")]
	private readonly string GOB_FEATURE_REWARD_LABEL;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x50")]
	private readonly string GOB_NEXT_REWARD_LABEL;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x58")]
	private readonly string IMG_REWARD_LABEL;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x60")]
	private readonly string TXT_REWARDINFO_LABEL;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x68")]
	private ElementObjectManager m_SingleEOM;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x70")]
	private ElementObjectManager m_DoubleEOM;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x78")]
	private ElementObjectManager m_NoRewardEOM;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x80")]
	private SingleViewField m_SingleViewField;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x88")]
	private DoubleViewField m_DoubleViewField;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x90")]
	private NoRewardViewField m_NoRewardViewField;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x98")]
	private ViewType m_ViewType;

	[Token(Token = "0x17000014")]
	private ViewType viewType
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20")]
		get
		{
			return default(ViewType);
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x3DDD30", Offset = "0x3DCF30", VA = "0x1803DDD30")]
		set
		{
		}
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x3DC420", Offset = "0x3DB620", VA = "0x1803DC420")]
	public void Initalize(ViewType defalutType)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x3DC240", Offset = "0x3DB440", VA = "0x1803DC240")]
	public List<ExtendedTextMeshProUGUI> GetTextMeshList()
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x3DD530", Offset = "0x3DC730", VA = "0x1803DD530")]
	public void UpdateSingleView(int goalInfo, int lapInfo, DiceRallyReward reward)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x3DCAC0", Offset = "0x3DBCC0", VA = "0x1803DCAC0")]
	public void UpdateDoubleView(int goalInfo, int nextLapInfo, int featureLapInfo, DiceRallyReward nextReward, DiceRallyReward featureReward)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x3DD280", Offset = "0x3DC480", VA = "0x1803DD280")]
	public void UpdateNoRewardView(int goalInfo, int lapInfo)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x3DDA10", Offset = "0x3DCC10", VA = "0x1803DDA10")]
	public GoalInfomationWidget()
	{
	}
}
