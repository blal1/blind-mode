using System.Collections;
using Il2CppDummyDll;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E41")]
public interface IDuelPreviewTask
{
	[Token(Token = "0x17000CFD")]
	DuelPreviewTaskRawData.TransitionType transitionType
	{
		[Token(Token = "0x6005653")]
		get;
	}

	[Token(Token = "0x6005654")]
	void Init(DuelPreviewTaskRawData taskData, DuelPreviewPlayer player);

	[Token(Token = "0x6005655")]
	IEnumerator ySetup();

	[Token(Token = "0x6005656")]
	IEnumerator Play();
}
