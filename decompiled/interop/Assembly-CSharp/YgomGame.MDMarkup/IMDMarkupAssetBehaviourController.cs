using System;
using System.Collections;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CBC")]
public interface IMDMarkupAssetBehaviourController
{
	[Token(Token = "0x6004D1E")]
	void Initialize(MDMarkupAssetViewController vc);

	[Token(Token = "0x6004D1F")]
	void NotificationStackEntry();

	[Token(Token = "0x6004D20")]
	IEnumerator PreprocessMMA(MDMarkupAsset mdMarkupAsset, Action onComplete);

	[Token(Token = "0x6004D21")]
	IEnumerator PostprocessMMA(IMDMarkupContainerWidget containerWidget, Action onComplete);

	[Token(Token = "0x6004D22")]
	void NotificationStackRemove();
}
