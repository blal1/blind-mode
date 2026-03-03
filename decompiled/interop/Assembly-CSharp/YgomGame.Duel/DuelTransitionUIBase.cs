using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20018DD")]
public abstract class DuelTransitionUIBase : DuelUIBase
{
	[Token(Token = "0x20018DE")]
	protected abstract class OperationInfoBase
	{
		[Token(Token = "0x400E907")]
		[FieldOffset(Offset = "0x10")]
		public Action act;

		[Token(Token = "0x400E908")]
		[FieldOffset(Offset = "0x18")]
		public Func<bool> wait;

		[Token(Token = "0x600A045")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		protected OperationInfoBase()
		{
		}
	}

	[Token(Token = "0x400E905")]
	[FieldOffset(Offset = "0x38")]
	protected Queue<OperationInfoBase> operationQueue;

	[Token(Token = "0x400E906")]
	[FieldOffset(Offset = "0x40")]
	protected OperationInfoBase currentOperation;

	[Token(Token = "0x600A042")]
	[Address(RVA = "0xEDC8B0", Offset = "0xEDBAB0", VA = "0x180EDC8B0")]
	private void UpdateOperation()
	{
	}

	[Token(Token = "0x600A043")]
	[Address(RVA = "0xEDC990", Offset = "0xEDBB90", VA = "0x180EDC990", Slot = "16")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600A044")]
	[Address(RVA = "0xEDCA80", Offset = "0xEDBC80", VA = "0x180EDCA80")]
	protected DuelTransitionUIBase()
	{
	}
}
