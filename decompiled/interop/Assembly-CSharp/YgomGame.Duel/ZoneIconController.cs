using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001AC3")]
public abstract class ZoneIconController
{
	[Token(Token = "0x2001AC4")]
	protected class IconInfo
	{
		[Token(Token = "0x400F58F")]
		[FieldOffset(Offset = "0x10")]
		public bool available;

		[Token(Token = "0x400F590")]
		[FieldOffset(Offset = "0x14")]
		public DuelEffectPool.Type effectTypeIcon;

		[Token(Token = "0x400F591")]
		[FieldOffset(Offset = "0x18")]
		public SimpleEffect effect;

		[Token(Token = "0x400F592")]
		[FieldOffset(Offset = "0x20")]
		public Material rollover;

		[Token(Token = "0x400F593")]
		[FieldOffset(Offset = "0x28")]
		public Material rolloverCard;

		[Token(Token = "0x600ADFE")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public IconInfo()
		{
		}
	}

	[Token(Token = "0x400F58D")]
	[FieldOffset(Offset = "0x10")]
	protected Dictionary<int, Dictionary<int, IconInfo>> availableList;

	[Token(Token = "0x400F58E")]
	[FieldOffset(Offset = "0x18")]
	protected RunEffectWorker worker;

	[Token(Token = "0x17001AEC")]
	protected virtual bool useCardEffect
	{
		[Token(Token = "0x600ADEF")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600ADF0")]
	[Address(RVA = "0x454BC0", Offset = "0x453DC0", VA = "0x180454BC0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600ADF1")]
	[Address(RVA = "0x455680", Offset = "0x454880", VA = "0x180455680")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600ADF2")]
	[Address(RVA = "0x453DE0", Offset = "0x452FE0", VA = "0x180453DE0")]
	public bool Activate(int player, int position, bool ignoreCard = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600ADF3")]
	[Address(RVA = "0x453FF0", Offset = "0x4531F0", VA = "0x180453FF0")]
	protected IconInfo CreateEffect(int player, int position, bool ignoreCard)
	{
		return null;
	}

	[Token(Token = "0x600ADF4")]
	[Address(RVA = "0x455550", Offset = "0x454750", VA = "0x180455550")]
	public void Show(int player, int position)
	{
	}

	[Token(Token = "0x600ADF5")]
	[Address(RVA = "0x4552C0", Offset = "0x4544C0", VA = "0x1804552C0")]
	public void ShowAvailableZone()
	{
	}

	[Token(Token = "0x600ADF6")]
	[Address(RVA = "0x454A90", Offset = "0x453C90", VA = "0x180454A90")]
	public void Hide(int player, int position)
	{
	}

	[Token(Token = "0x600ADF7")]
	[Address(RVA = "0x4545C0", Offset = "0x4537C0", VA = "0x1804545C0")]
	public void DeactivateAll()
	{
	}

	[Token(Token = "0x600ADF8")]
	[Address(RVA = "0x454D00", Offset = "0x453F00", VA = "0x180454D00")]
	public bool IsActivated(int player, int position, bool transEx = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600ADF9")]
	[Address(RVA = "0x455210", Offset = "0x454410", VA = "0x180455210")]
	public void SetStatus(int player, int position, bool selected)
	{
	}

	[Token(Token = "0x600ADFA")]
	[Address(RVA = "0x455110", Offset = "0x454310", VA = "0x180455110")]
	private void SetStatus(IconInfo info, bool selected)
	{
	}

	[Token(Token = "0x600ADFB")]
	[Address(RVA = "0x454EB0", Offset = "0x4540B0", VA = "0x180454EB0")]
	public void SetStatusAll(bool selected)
	{
	}

	[Token(Token = "0x600ADFC")]
	[Address(RVA = "0x4548D0", Offset = "0x453AD0", VA = "0x1804548D0")]
	public (int, int) GetHighPriorityAvailableZone(bool linkFromExDeck)
	{
		return default((int, int));
	}

	[Token(Token = "0x600ADFD")]
	[Address(RVA = "0x4556B0", Offset = "0x4548B0", VA = "0x1804556B0")]
	protected ZoneIconController()
	{
	}
}
