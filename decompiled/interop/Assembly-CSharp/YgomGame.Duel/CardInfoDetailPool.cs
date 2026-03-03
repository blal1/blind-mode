using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x200185D")]
public class CardInfoDetailPool : MonoBehaviour
{
	[Token(Token = "0x200185E")]
	public class RelativeList
	{
		[Token(Token = "0x400E4C8")]
		[FieldOffset(Offset = "0x10")]
		private GenericCardListEx m_Widget;

		[Token(Token = "0x400E4C9")]
		[FieldOffset(Offset = "0x18")]
		private GenericScrollView m_ScrollView;

		[Token(Token = "0x400E4CA")]
		[FieldOffset(Offset = "0x20")]
		public Action<int> onClickCard;

		[Token(Token = "0x170017C6")]
		public GenericCardListEx widget
		{
			[Token(Token = "0x6009BBE")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170017C7")]
		public bool isStandby
		{
			[Token(Token = "0x6009BBF")]
			[Address(RVA = "0xE9D420", Offset = "0xE9C620", VA = "0x180E9D420")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6009BC0")]
		[Address(RVA = "0xE9D270", Offset = "0xE9C470", VA = "0x180E9D270")]
		public static void Create(Transform parent, Action<RelativeList> finishedCallback)
		{
		}

		[Token(Token = "0x6009BC1")]
		[Address(RVA = "0xE9D400", Offset = "0xE9C600", VA = "0x180E9D400")]
		private void OnClickCard(int mrk)
		{
		}

		[Token(Token = "0x6009BC2")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public RelativeList()
		{
		}
	}

	[Token(Token = "0x400E4C4")]
	[FieldOffset(Offset = "0x0")]
	private static CardInfoDetailPool s_Instance;

	[Token(Token = "0x400E4C5")]
	[FieldOffset(Offset = "0x20")]
	private Stack<CardInfoDetail> m_CardDetailPool;

	[Token(Token = "0x400E4C6")]
	[FieldOffset(Offset = "0x28")]
	private Stack<CardInfoDetail> m_DownloadCardDetailPool;

	[Token(Token = "0x400E4C7")]
	[FieldOffset(Offset = "0x30")]
	private Stack<RelativeList> m_RelativeListPool;

	[Token(Token = "0x170017C5")]
	private static CardInfoDetailPool instance
	{
		[Token(Token = "0x6009BB0")]
		[Address(RVA = "0xE86250", Offset = "0xE85450", VA = "0x180E86250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009BB1")]
	[Address(RVA = "0xE85640", Offset = "0xE84840", VA = "0x180E85640")]
	public static int GetReusableCount(bool flag)
	{
		return default(int);
	}

	[Token(Token = "0x6009BB2")]
	[Address(RVA = "0xE852A0", Offset = "0xE844A0", VA = "0x180E852A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6009BB3")]
	[Address(RVA = "0xE85C70", Offset = "0xE84E70", VA = "0x180E85C70")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009BB4")]
	[Address(RVA = "0xE85D80", Offset = "0xE84F80", VA = "0x180E85D80")]
	public static void Release()
	{
	}

	[Token(Token = "0x6009BB5")]
	[Address(RVA = "0xE855E0", Offset = "0xE847E0", VA = "0x180E855E0")]
	public static void CreateOrReuse(Transform parent, Action finishedCallback, bool flag = false)
	{
	}

	[Token(Token = "0x6009BB6")]
	[Address(RVA = "0xE856A0", Offset = "0xE848A0", VA = "0x180E856A0")]
	private void InnerCreateOrReuse(Transform parent, Action finishedCallback, bool flag = false)
	{
	}

	[Token(Token = "0x6009BB7")]
	[Address(RVA = "0xE85E60", Offset = "0xE85060", VA = "0x180E85E60")]
	public static void ReserveToReuse(Action finishedCallback, bool flag = false)
	{
	}

	[Token(Token = "0x6009BB8")]
	[Address(RVA = "0xE85920", Offset = "0xE84B20", VA = "0x180E85920")]
	private void InnerReserveToReuse(Action finishedCallback, bool flag = false)
	{
	}

	[Token(Token = "0x6009BB9")]
	[Address(RVA = "0xE860B0", Offset = "0xE852B0", VA = "0x180E860B0")]
	public static void ReturnToReuse(CardInfoDetail cardInfoDetail, bool flag = false)
	{
	}

	[Token(Token = "0x6009BBA")]
	[Address(RVA = "0xE85A60", Offset = "0xE84C60", VA = "0x180E85A60")]
	private void InnerReturnToReuse(CardInfoDetail cardInfoDetail, bool flag = false)
	{
	}

	[Token(Token = "0x6009BBB")]
	[Address(RVA = "0xE85330", Offset = "0xE84530", VA = "0x180E85330")]
	public static void CreateOrReuseRelativeList(Transform parent, Action<RelativeList> finishedCallback)
	{
	}

	[Token(Token = "0x6009BBC")]
	[Address(RVA = "0xE85FB0", Offset = "0xE851B0", VA = "0x180E85FB0")]
	public static void ReturnToReuseRelative(RelativeList relativeList)
	{
	}

	[Token(Token = "0x6009BBD")]
	[Address(RVA = "0xE86160", Offset = "0xE85360", VA = "0x180E86160")]
	public CardInfoDetailPool()
	{
	}
}
