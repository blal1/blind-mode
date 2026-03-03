using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B3C")]
public interface IPromoCodeBehaviour
{
	[Token(Token = "0x2000B3D")]
	public enum Type
	{
		[Token(Token = "0x400961E")]
		SerialCode,
		[Token(Token = "0x400961F")]
		InviteSend,
		[Token(Token = "0x4009620")]
		InviteReceive
	}

	[Token(Token = "0x2000B3E")]
	public enum ProgressState
	{
		[Token(Token = "0x4009622")]
		InProgress,
		[Token(Token = "0x4009623")]
		Failed,
		[Token(Token = "0x4009624")]
		Success
	}

	[Token(Token = "0x17000924")]
	Type type
	{
		[Token(Token = "0x60044D8")]
		get;
	}

	[Token(Token = "0x17000925")]
	ProgressState progressState
	{
		[Token(Token = "0x60044D9")]
		get;
	}

	[Token(Token = "0x17000926")]
	string viewLabel
	{
		[Token(Token = "0x60044DA")]
		get;
	}

	[Token(Token = "0x17000927")]
	string titleCategoryText
	{
		[Token(Token = "0x60044DB")]
		get;
	}

	[Token(Token = "0x17000928")]
	string titleBodyText
	{
		[Token(Token = "0x60044DC")]
		get;
	}

	[Token(Token = "0x17000929")]
	string headerButtonLabel
	{
		[Token(Token = "0x60044DD")]
		get;
	}

	[Token(Token = "0x1700092A")]
	Action headerButtonAction
	{
		[Token(Token = "0x60044DE")]
		get;
	}

	[Token(Token = "0x1700092B")]
	bool useInputCoolTime
	{
		[Token(Token = "0x60044DF")]
		get;
	}

	[Token(Token = "0x1700092C")]
	Action<OnErrorBehaviour, string> onErrorCallback
	{
		[Token(Token = "0x60044E7")]
		get;
		[Token(Token = "0x60044E8")]
		set;
	}

	[Token(Token = "0x60044E0")]
	bool IsValid();

	[Token(Token = "0x60044E1")]
	void Initialize(IPromoCodeBehaviourHandler handler);

	[Token(Token = "0x60044E2")]
	void GetCooltimeTargets(List<InputFieldWidget> res);

	[Token(Token = "0x60044E3")]
	void OnCreatedView(ElementObjectManager view);

	[Token(Token = "0x60044E4")]
	void BeginInitialize(PromoCodesViewController.SourceContainer sourceContainer);

	[Token(Token = "0x60044E5")]
	IEnumerator ProgressUpdate();

	[Token(Token = "0x60044E6")]
	void OnReady();
}
