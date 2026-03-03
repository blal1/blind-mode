using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000243")]
public class API
{
	[Token(Token = "0x6000D59")]
	[Address(RVA = "0xD30B80", Offset = "0xD2FD80", VA = "0x180D30B80")]
	public static Handle System_info()
	{
		return null;
	}

	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0xD30CA0", Offset = "0xD2FEA0", VA = "0x180D30CA0")]
	public static Handle System_set_language(string _lang_)
	{
		return null;
	}

	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0xD30DA0", Offset = "0xD2FFA0", VA = "0x180D30DA0")]
	public static Handle System_toggle_crossplay()
	{
		return null;
	}

	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0xD30E20", Offset = "0xD30020", VA = "0x180D30E20")]
	public static Handle System_toggle_duelbgm()
	{
		return null;
	}

	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0xD1D090", Offset = "0xD1C290", VA = "0x180D1D090")]
	public static Handle Account_create(int _agreement_type_, string[] _agree_info_, int _country_, Dictionary<string, object> _enquete_results_)
	{
		return null;
	}

	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0xD1CE40", Offset = "0xD1C040", VA = "0x180D1CE40")]
	public static Handle Account_create(string _auth_session_, int _agreement_type_, string[] _agree_info_, int _country_, Dictionary<string, object> _enquete_results_)
	{
		return null;
	}

	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0xD1C950", Offset = "0xD1BB50", VA = "0x180D1C950")]
	public static Handle Account_auth(Dictionary<string, object> _opt_)
	{
		return null;
	}

	[Token(Token = "0x6000D60")]
	[Address(RVA = "0xD1CAC0", Offset = "0xD1BCC0", VA = "0x180D1CAC0")]
	public static Handle Account_auth(string _auth_session_, bool _valid_steam_overlay_)
	{
		return null;
	}

	[Token(Token = "0x6000D61")]
	[Address(RVA = "0xD1C7E0", Offset = "0xD1B9E0", VA = "0x180D1C7E0")]
	public static Handle Account_auth(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D62")]
	[Address(RVA = "0xD1CC80", Offset = "0xD1BE80", VA = "0x180D1CC80")]
	public static Handle Account_auth(string _auth_session_, int _label_)
	{
		return null;
	}

	[Token(Token = "0x6000D63")]
	[Address(RVA = "0xD1D940", Offset = "0xD1CB40", VA = "0x180D1D940")]
	public static Handle Account_re_agree(string[] _agree_info_, bool _optout_)
	{
		return null;
	}

	[Token(Token = "0x6000D64")]
	[Address(RVA = "0xD1D3E0", Offset = "0xD1C5E0", VA = "0x180D1D3E0")]
	public static Handle Account_is_regist_platform()
	{
		return null;
	}

	[Token(Token = "0x6000D65")]
	[Address(RVA = "0xD1DA80", Offset = "0xD1CC80", VA = "0x180D1DA80")]
	public static Handle Account_regist_platform()
	{
		return null;
	}

	[Token(Token = "0x6000D66")]
	[Address(RVA = "0xD1D2C0", Offset = "0xD1C4C0", VA = "0x180D1D2C0")]
	public static Handle Account_inherit_platform()
	{
		return null;
	}

	[Token(Token = "0x6000D67")]
	[Address(RVA = "0xD1D840", Offset = "0xD1CA40", VA = "0x180D1D840")]
	public static Handle Account_kid_get_link_url()
	{
		return null;
	}

	[Token(Token = "0x6000D68")]
	[Address(RVA = "0xD1D6A0", Offset = "0xD1C8A0", VA = "0x180D1D6A0")]
	public static Handle Account_kid_check_linked()
	{
		return null;
	}

	[Token(Token = "0x6000D69")]
	[Address(RVA = "0xD1D720", Offset = "0xD1C920", VA = "0x180D1D720")]
	public static Handle Account_kid_get_inherit_url()
	{
		return null;
	}

	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0xD1D500", Offset = "0xD1C700", VA = "0x180D1D500")]
	public static Handle Account_kid_check_inherited(string _kid_inherit_nonce_, string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0xD1D8C0", Offset = "0xD1CAC0", VA = "0x180D1D8C0")]
	public static Handle Account_kid_get_neuron_token()
	{
		return null;
	}

	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0xD1DF60", Offset = "0xD1D160", VA = "0x180D1DF60")]
	public static Handle Account_set_opt_out()
	{
		return null;
	}

	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0xD1DBA0", Offset = "0xD1CDA0", VA = "0x180D1DBA0")]
	public static Handle Account_report_user(int _reported_pcode_, int[] _report_ids_)
	{
		return null;
	}

	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0xD1DFE0", Offset = "0xD1D1E0", VA = "0x180D1DFE0")]
	public static Handle Account_unlock(string _pass_)
	{
		return null;
	}

	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0xD1DEE0", Offset = "0xD1D0E0", VA = "0x180D1DEE0")]
	public static Handle Account_set_official_settings()
	{
		return null;
	}

	[Token(Token = "0x6000D70")]
	[Address(RVA = "0xD1DCE0", Offset = "0xD1CEE0", VA = "0x180D1DCE0")]
	public static Handle Account_set_app_settings(Dictionary<string, object> _app_settings_)
	{
		return null;
	}

	[Token(Token = "0x6000D71")]
	[Address(RVA = "0xD1DDE0", Offset = "0xD1CFE0", VA = "0x180D1DDE0")]
	public static Handle Account_set_game_settings(Dictionary<string, object> _settings_)
	{
		return null;
	}

	[Token(Token = "0x6000D72")]
	[Address(RVA = "0xD1B4B0", Offset = "0xD1A6B0", VA = "0x180D1B4B0")]
	public static Handle Account_GC_get_requirements()
	{
		return null;
	}

	[Token(Token = "0x6000D73")]
	[Address(RVA = "0xD1B0A0", Offset = "0xD1A2A0", VA = "0x180D1B0A0")]
	public static Handle Account_GC_check(string _birth_)
	{
		return null;
	}

	[Token(Token = "0x6000D74")]
	[Address(RVA = "0xD1B210", Offset = "0xD1A410", VA = "0x180D1B210")]
	public static Handle Account_GC_check(int _age_)
	{
		return null;
	}

	[Token(Token = "0x6000D75")]
	[Address(RVA = "0xD1B770", Offset = "0xD1A970", VA = "0x180D1B770")]
	public static Handle Account_GC_send_mail(string _email_)
	{
		return null;
	}

	[Token(Token = "0x6000D76")]
	[Address(RVA = "0xD1B390", Offset = "0xD1A590", VA = "0x180D1B390")]
	public static Handle Account_GC_generate_otp()
	{
		return null;
	}

	[Token(Token = "0x6000D77")]
	[Address(RVA = "0xD1B650", Offset = "0xD1A850", VA = "0x180D1B650")]
	public static Handle Account_GC_get_status()
	{
		return null;
	}

	[Token(Token = "0x6000D78")]
	[Address(RVA = "0xD1B8E0", Offset = "0xD1AAE0", VA = "0x180D1B8E0")]
	public static Handle Account_GC_upgrade()
	{
		return null;
	}

	[Token(Token = "0x6000D79")]
	[Address(RVA = "0xD1B5D0", Offset = "0xD1A7D0", VA = "0x180D1B5D0")]
	public static Handle Account_GC_get_session()
	{
		return null;
	}

	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0xD1AFA0", Offset = "0xD1A1A0", VA = "0x180D1AFA0")]
	public static Handle Account_GC_auth_send_mail(string _email_)
	{
		return null;
	}

	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0xD1AEA0", Offset = "0xD1A0A0", VA = "0x180D1AEA0")]
	public static Handle Account_GC_auth_generate_otp()
	{
		return null;
	}

	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0xD1AF20", Offset = "0xD1A120", VA = "0x180D1AF20")]
	public static Handle Account_GC_auth_get_status()
	{
		return null;
	}

	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0xD1C120", Offset = "0xD1B320", VA = "0x180D1C120")]
	public static Handle Account_Steam_get_user_id(string _session_ticket_)
	{
		return null;
	}

	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0xD1C290", Offset = "0xD1B490", VA = "0x180D1C290")]
	public static Handle Account_Steam_re_auth(string _session_ticket_)
	{
		return null;
	}

	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0xD1BD40", Offset = "0xD1AF40", VA = "0x180D1BD40")]
	public static Handle Account_PS_get_user_id(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D80")]
	[Address(RVA = "0xD1BEB0", Offset = "0xD1B0B0", VA = "0x180D1BEB0")]
	public static Handle Account_PS_re_auth(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D81")]
	[Address(RVA = "0xD1C020", Offset = "0xD1B220", VA = "0x180D1C020")]
	public static Handle Account_PS_refresh_auth(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D82")]
	[Address(RVA = "0xD1C400", Offset = "0xD1B600", VA = "0x180D1C400")]
	public static Handle Account_XBox_get_user_id(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D83")]
	[Address(RVA = "0xD1C570", Offset = "0xD1B770", VA = "0x180D1C570")]
	public static Handle Account_XBox_re_auth(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D84")]
	[Address(RVA = "0xD1C6E0", Offset = "0xD1B8E0", VA = "0x180D1C6E0")]
	public static Handle Account_XBox_refresh_auth(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D85")]
	[Address(RVA = "0xD1B960", Offset = "0xD1AB60", VA = "0x180D1B960")]
	public static Handle Account_Nx_get_user_id(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D86")]
	[Address(RVA = "0xD1BAD0", Offset = "0xD1ACD0", VA = "0x180D1BAD0")]
	public static Handle Account_Nx_re_auth(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D87")]
	[Address(RVA = "0xD1BC40", Offset = "0xD1AE40", VA = "0x180D1BC40")]
	public static Handle Account_Nx_refresh_auth(string _auth_session_)
	{
		return null;
	}

	[Token(Token = "0x6000D88")]
	[Address(RVA = "0xD330F0", Offset = "0xD322F0", VA = "0x180D330F0")]
	public static Handle User_entry()
	{
		return null;
	}

	[Token(Token = "0x6000D89")]
	[Address(RVA = "0xD33310", Offset = "0xD32510", VA = "0x180D33310")]
	public static Handle User_home()
	{
		return null;
	}

	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0xD33510", Offset = "0xD32710", VA = "0x180D33510")]
	public static Handle User_profile(long _pcode_)
	{
		return null;
	}

	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0xD33620", Offset = "0xD32820", VA = "0x180D33620")]
	public static Handle User_record(long _pcode_)
	{
		return null;
	}

	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0xD33840", Offset = "0xD32A40", VA = "0x180D33840")]
	public static Handle User_set_profile(Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0xD33730", Offset = "0xD32930", VA = "0x180D33730")]
	public static Handle User_replay_list(long _pcode_)
	{
		return null;
	}

	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0xD33210", Offset = "0xD32410", VA = "0x180D33210")]
	public static Handle User_first_name_entry(string _name_)
	{
		return null;
	}

	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0xD33410", Offset = "0xD32610", VA = "0x180D33410")]
	public static Handle User_name_entry(string _name_)
	{
		return null;
	}

	[Token(Token = "0x6000D90")]
	[Address(RVA = "0xD33070", Offset = "0xD32270", VA = "0x180D33070")]
	public static Handle User_complete_home_guide()
	{
		return null;
	}

	[Token(Token = "0x6000D91")]
	[Address(RVA = "0xD33390", Offset = "0xD32590", VA = "0x180D33390")]
	public static Handle User_item_get_history()
	{
		return null;
	}

	[Token(Token = "0x6000D92")]
	[Address(RVA = "0xD26D00", Offset = "0xD25F00", VA = "0x180D26D00")]
	public static Handle Duel_begin(Dictionary<string, object> _rule_)
	{
		return null;
	}

	[Token(Token = "0x6000D93")]
	[Address(RVA = "0xD26E00", Offset = "0xD26000", VA = "0x180D26E00")]
	public static Handle Duel_end(Dictionary<string, object> _params_)
	{
		return null;
	}

	[Token(Token = "0x6000D94")]
	[Address(RVA = "0xD26F60", Offset = "0xD26160", VA = "0x180D26F60")]
	public static Handle Duel_matching(Dictionary<string, object> _rule_)
	{
		return null;
	}

	[Token(Token = "0x6000D95")]
	[Address(RVA = "0xD26F00", Offset = "0xD26100", VA = "0x180D26F00")]
	public static Handle Duel_matching_cancel()
	{
		return null;
	}

	[Token(Token = "0x6000D96")]
	[Address(RVA = "0xD27140", Offset = "0xD26340", VA = "0x180D27140")]
	public static Handle Duel_start_waiting()
	{
		return null;
	}

	[Token(Token = "0x6000D97")]
	[Address(RVA = "0xD27040", Offset = "0xD26240", VA = "0x180D27040")]
	public static Handle Duel_start_selecting(int _select_)
	{
		return null;
	}

	[Token(Token = "0x6000D98")]
	[Address(RVA = "0xD271A0", Offset = "0xD263A0", VA = "0x180D271A0")]
	public static Handle Duel_team_matching_leader(Dictionary<string, object> _rule_)
	{
		return null;
	}

	[Token(Token = "0x6000D99")]
	[Address(RVA = "0xD27280", Offset = "0xD26480", VA = "0x180D27280")]
	public static Handle Duel_team_matching_member(Dictionary<string, object> _rule_)
	{
		return null;
	}

	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0xD32AF0", Offset = "0xD31CF0", VA = "0x180D32AF0")]
	public static Handle Tournament_info()
	{
		return null;
	}

	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0xD32880", Offset = "0xD31A80", VA = "0x180D32880")]
	public static Handle Tournament_entry(int _tid_)
	{
		return null;
	}

	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0xD32660", Offset = "0xD31860", VA = "0x180D32660")]
	public static Handle Tournament_detail(int _tid_)
	{
		return null;
	}

	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0xD32C80", Offset = "0xD31E80", VA = "0x180D32C80")]
	public static Handle Tournament_reward_list(int _tid_)
	{
		return null;
	}

	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0xD32770", Offset = "0xD31970", VA = "0x180D32770")]
	public static Handle Tournament_duel_history(int _tid_)
	{
		return null;
	}

	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0xD32B70", Offset = "0xD31D70", VA = "0x180D32B70")]
	public static Handle Tournament_ranking(int _tid_)
	{
		return null;
	}

	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0xD32990", Offset = "0xD31B90", VA = "0x180D32990")]
	public static Handle Tournament_get_deck_list(int _tid_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0xD32ED0", Offset = "0xD320D0", VA = "0x180D32ED0")]
	public static Handle Tournament_set_deck(int _tid_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000DA2")]
	[Address(RVA = "0xD32D90", Offset = "0xD31F90", VA = "0x180D32D90")]
	public static Handle Tournament_set_deck_accessory(int _tid_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000DA3")]
	[Address(RVA = "0xD32550", Offset = "0xD31750", VA = "0x180D32550")]
	public static Handle Tournament_delete_deck(int _tid_)
	{
		return null;
	}

	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0xD23F70", Offset = "0xD23170", VA = "0x180D23F70")]
	public static Handle Deck_get_deck()
	{
		return null;
	}

	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0xD23E10", Offset = "0xD23010", VA = "0x180D23E10")]
	public static Handle Deck_get_deck_list(int _deck_id_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0xD24380", Offset = "0xD23580", VA = "0x180D24380")]
	public static Handle Deck_update_deck(int _deck_id_, string _name_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _pick_cards_, Dictionary<string, object> _accessory_)
	{
		return null;
	}

	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0xD24540", Offset = "0xD23740", VA = "0x180D24540")]
	public static Handle Deck_update_deck_reg(int _deck_id_, string _name_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _pick_cards_, Dictionary<string, object> _accessory_, int _regulation_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0xD23A70", Offset = "0xD22C70", VA = "0x180D23A70")]
	public static Handle Deck_delete_deck(int _deck_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0xD23B80", Offset = "0xD22D80", VA = "0x180D23B80")]
	public static Handle Deck_delete_deck_multi(int[] _deck_id_list_)
	{
		return null;
	}

	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0xD237B0", Offset = "0xD229B0", VA = "0x180D237B0")]
	public static Handle Deck_check_deck_regulation(int _deck_id_, int _regulation_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0xD240F0", Offset = "0xD232F0", VA = "0x180D240F0")]
	public static Handle Deck_set_deck_accessory(int _deck_id_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0xD23FF0", Offset = "0xD231F0", VA = "0x180D23FF0")]
	public static Handle Deck_set_accessory(Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0xD24230", Offset = "0xD23430", VA = "0x180D24230")]
	public static Handle Deck_set_select_deck(int _mode_, int _deck_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0xD232E0", Offset = "0xD224E0", VA = "0x180D232E0")]
	public static Handle Deck_CopyStructure(int _structure_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0xD23970", Offset = "0xD22B70", VA = "0x180D23970")]
	public static Handle Deck_copy_structure_multi(int[] _structure_ids_)
	{
		return null;
	}

	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0xD235B0", Offset = "0xD227B0", VA = "0x180D235B0")]
	public static Handle Deck_SetFavoriteCards(Dictionary<string, object> _card_list_)
	{
		return null;
	}

	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0xD236B0", Offset = "0xD228B0", VA = "0x180D236B0")]
	public static Handle Deck_SetLockCards(Dictionary<string, object> _card_list_)
	{
		return null;
	}

	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0xD233F0", Offset = "0xD225F0", VA = "0x180D233F0")]
	public static Handle Deck_ExportDeck(string _N_token_, int _deck_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0xD23530", Offset = "0xD22730", VA = "0x180D23530")]
	public static Handle Deck_GetAccessoryDetail()
	{
		return null;
	}

	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0xD23C80", Offset = "0xD22E80", VA = "0x180D23C80")]
	public static Handle Deck_get_auto_deck(int[] _card_ids_, int _main_deck_num_, int _type_)
	{
		return null;
	}

	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0xD253F0", Offset = "0xD245F0", VA = "0x180D253F0")]
	public static Handle Download_begin()
	{
		return null;
	}

	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0xD25510", Offset = "0xD24710", VA = "0x180D25510")]
	public static Handle Download_complete()
	{
		return null;
	}

	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0xD25630", Offset = "0xD24830", VA = "0x180D25630")]
	public static Handle Download_progress(string _dl_end_)
	{
		return null;
	}

	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0xD22290", Offset = "0xD21490", VA = "0x180D22290")]
	public static Handle Craft_exchange(int _card_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0xD223A0", Offset = "0xD215A0", VA = "0x180D223A0")]
	public static Handle Craft_exchange_multi(Dictionary<string, object> _card_list_, Dictionary<string, object> _compensation_list_)
	{
		return null;
	}

	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0xD226D0", Offset = "0xD218D0", VA = "0x180D226D0")]
	public static Handle Craft_generate(int _card_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0xD227E0", Offset = "0xD219E0", VA = "0x180D227E0")]
	public static Handle Craft_generate_multi(Dictionary<string, object> _card_list_, bool _check_, int[] _confirm_compensation_list_)
	{
		return null;
	}

	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0xD22950", Offset = "0xD21B50", VA = "0x180D22950")]
	public static Handle Craft_get_card_route(int _card_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0xD224D0", Offset = "0xD216D0", VA = "0x180D224D0")]
	public static Handle Craft_generate_boost(int _card_id_, int _premium_type_, int _cost_cp_, bool _check_, int[] _confirm_compensation_list_)
	{
		return null;
	}

	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0xD28B90", Offset = "0xD27D90", VA = "0x180D28B90")]
	public static Handle Friend_follow(long _pcode_, int _delete_)
	{
		return null;
	}

	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0xD28CF0", Offset = "0xD27EF0", VA = "0x180D28CF0")]
	public static Handle Friend_follow_other_routes(long _pcode_, int _route_)
	{
		return null;
	}

	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0xD292F0", Offset = "0xD284F0", VA = "0x180D292F0")]
	public static Handle Friend_set_pin(long _pcode_, int _delete_, int _update_work_)
	{
		return null;
	}

	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0xD28E50", Offset = "0xD28050", VA = "0x180D28E50")]
	public static Handle Friend_get_follower(long _date_, long _pcode_, int _dir_)
	{
		return null;
	}

	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0xD28FF0", Offset = "0xD281F0", VA = "0x180D28FF0")]
	public static Handle Friend_get_list(bool _all_)
	{
		return null;
	}

	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0xD29100", Offset = "0xD28300", VA = "0x180D29100")]
	public static Handle Friend_id_search(long _pcode_)
	{
		return null;
	}

	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0xD29490", Offset = "0xD28690", VA = "0x180D29490")]
	public static Handle Friend_tag_search(int[] _tag_)
	{
		return null;
	}

	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0xD28A30", Offset = "0xD27C30", VA = "0x180D28A30")]
	public static Handle Friend_block(long _pcode_, int _delete_)
	{
		return null;
	}

	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0xD29210", Offset = "0xD28410", VA = "0x180D29210")]
	public static Handle Friend_refresh_info(long[] _pcode_list_)
	{
		return null;
	}

	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0xD2ACF0", Offset = "0xD29EF0", VA = "0x180D2ACF0")]
	public static Handle Mission_get_list()
	{
		return null;
	}

	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0xD2AD70", Offset = "0xD29F70", VA = "0x180D2AD70")]
	public static Handle Mission_receive(int _pool_id_, int _mission_id_, int _goal_pos_)
	{
		return null;
	}

	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0xD2AB90", Offset = "0xD29D90", VA = "0x180D2AB90")]
	public static Handle Mission_bulk_receive(int[] _bulk_pool_id_, int[] _bulk_mission_id_, int[] _bulk_goal_pos_)
	{
		return null;
	}

	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0xD2B0A0", Offset = "0xD2A2A0", VA = "0x180D2B0A0")]
	public static Handle PanelMission_get_list()
	{
		return null;
	}

	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0xD2B120", Offset = "0xD2A320", VA = "0x180D2B120")]
	public static Handle PanelMission_receive(int _pool_id_, int _mission_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0xD2C870", Offset = "0xD2BA70", VA = "0x180D2C870")]
	public static Handle PvP_watch_duel(long _pcode_, long _rapid_)
	{
		return null;
	}

	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0xD2BE00", Offset = "0xD2B000", VA = "0x180D2BE00")]
	public static Handle PvP_replay_duel(long _pcode_, long _did_)
	{
		return null;
	}

	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0xD2BF60", Offset = "0xD2B160", VA = "0x180D2BF60")]
	public static Handle PvP_save_replay(int _mode_, long _did_, int _eid_)
	{
		return null;
	}

	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0xD2C100", Offset = "0xD2B300", VA = "0x180D2C100")]
	public static Handle PvP_save_replay_new(int _mode_, long _did_, int _eid_, bool _open_)
	{
		return null;
	}

	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0xD2B9B0", Offset = "0xD2ABB0", VA = "0x180D2B9B0")]
	public static Handle PvP_remove_replay(long _did_)
	{
		return null;
	}

	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0xD2BAC0", Offset = "0xD2ACC0", VA = "0x180D2BAC0")]
	public static Handle PvP_replay_duel_history(int _idx_, int _mode_, long _did_, int _eid_)
	{
		return null;
	}

	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0xD2BCA0", Offset = "0xD2AEA0", VA = "0x180D2BCA0")]
	public static Handle PvP_replay_duel_history_with_room(long _did_, long _pcode_)
	{
		return null;
	}

	[Token(Token = "0x6000DD3")]
	[Address(RVA = "0xD2B5B0", Offset = "0xD2A7B0", VA = "0x180D2B5B0")]
	public static Handle PvP_duel_history(int _mode_)
	{
		return null;
	}

	[Token(Token = "0x6000DD4")]
	[Address(RVA = "0xD2C440", Offset = "0xD2B640", VA = "0x180D2C440")]
	public static Handle PvP_set_replay_open(long _did_, bool _open_)
	{
		return null;
	}

	[Token(Token = "0x6000DD5")]
	[Address(RVA = "0xD2C2E0", Offset = "0xD2B4E0", VA = "0x180D2C2E0")]
	public static Handle PvP_set_replay_lock(long _did_, bool _lock_)
	{
		return null;
	}

	[Token(Token = "0x6000DD6")]
	[Address(RVA = "0xD2C730", Offset = "0xD2B930", VA = "0x180D2C730")]
	public static Handle PvP_set_replay_tags(long _did_, int[] _tags_)
	{
		return null;
	}

	[Token(Token = "0x6000DD7")]
	[Address(RVA = "0xD2C5A0", Offset = "0xD2B7A0", VA = "0x180D2C5A0")]
	public static Handle PvP_set_replay_pick_cards(long _did_, int _myid_, Dictionary<string, object> _pcards_)
	{
		return null;
	}

	[Token(Token = "0x6000DD8")]
	[Address(RVA = "0xD2B6C0", Offset = "0xD2A8C0", VA = "0x180D2B6C0")]
	public static Handle PvP_get_history_deck(long _did_, int _mode_, int _idx_, int _is_own_)
	{
		return null;
	}

	[Token(Token = "0x6000DD9")]
	[Address(RVA = "0xD2B8A0", Offset = "0xD2AAA0", VA = "0x180D2B8A0")]
	public static Handle PvP_get_replay_deck(long _did_)
	{
		return null;
	}

	[Token(Token = "0x6000DDA")]
	[Address(RVA = "0xD30A70", Offset = "0xD2FC70", VA = "0x180D30A70")]
	public static Handle Structure_first(int _structure_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0xD309F0", Offset = "0xD2FBF0", VA = "0x180D309F0")]
	public static Handle Structure_check_have_structure()
	{
		return null;
	}

	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0xD29590", Offset = "0xD28790", VA = "0x180D29590")]
	public static Handle Gacha_get_card_list(int _card_list_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0xD296A0", Offset = "0xD288A0", VA = "0x180D296A0")]
	public static Handle Gacha_get_probability(int _gacha_id_, int _shop_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0xD2FCE0", Offset = "0xD2EEE0", VA = "0x180D2FCE0")]
	public static Handle Shop_get_list(int _category_, bool _no_display_, int[] _recovery_report_)
	{
		return null;
	}

	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0xD30010", Offset = "0xD2F210", VA = "0x180D30010")]
	public static Handle Shop_purchase(int _shop_id_, int _price_id_, int _count_, Dictionary<string, object> _args_)
	{
		return null;
	}

	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0xD301D0", Offset = "0xD2F3D0", VA = "0x180D301D0")]
	public static Handle Shop_visit(int[] _shop_ids_)
	{
		return null;
	}

	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0xD2FE70", Offset = "0xD2F070", VA = "0x180D2FE70")]
	public static Handle Shop_market_slot_open(int _shopId_, int _marketId_, int _slot_)
	{
		return null;
	}

	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0xD218C0", Offset = "0xD20AC0", VA = "0x180D218C0")]
	public static Handle Challenge_detail(int _mode_, int _season_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0xD21D00", Offset = "0xD20F00", VA = "0x180D21D00")]
	public static Handle Challenge_ranking(int _mode_, int _season_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0xD21FA0", Offset = "0xD211A0", VA = "0x180D21FA0")]
	public static Handle Challenge_set_deck(int _mode_, int _deck_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0xD21A10", Offset = "0xD20C10", VA = "0x180D21A10")]
	public static Handle Challenge_duel_history(int _mode_, int _season_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0xD21E50", Offset = "0xD21050", VA = "0x180D21E50")]
	public static Handle Challenge_reward_list(int _mode_, int _season_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0xD220F0", Offset = "0xD212F0", VA = "0x180D220F0")]
	public static Handle Challenge_set_use_deck(int _mode_, int _season_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0xD21B60", Offset = "0xD20D60", VA = "0x180D21B60")]
	public static Handle Challenge_get_rental_deck_list(int _mode_, int _season_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0xD20CF0", Offset = "0xD1FEF0", VA = "0x180D20CF0")]
	public static Handle Casual_detail()
	{
		return null;
	}

	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0xD20D70", Offset = "0xD1FF70", VA = "0x180D20D70")]
	public static Handle Casual_duel_history()
	{
		return null;
	}

	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0xD30570", Offset = "0xD2F770", VA = "0x180D30570")]
	public static Handle Solo_info(bool _back_)
	{
		return null;
	}

	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0xD30350", Offset = "0xD2F550", VA = "0x180D30350")]
	public static Handle Solo_detail(int _chapter_)
	{
		return null;
	}

	[Token(Token = "0x6000DED")]
	[Address(RVA = "0xD308E0", Offset = "0xD2FAE0", VA = "0x180D308E0")]
	public static Handle Solo_start(int _chapter_)
	{
		return null;
	}

	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0xD302D0", Offset = "0xD2F4D0", VA = "0x180D302D0")]
	public static Handle Solo_deck_check()
	{
		return null;
	}

	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0xD30680", Offset = "0xD2F880", VA = "0x180D30680")]
	public static Handle Solo_set_use_deck_type(int _chapter_, int _deck_type_)
	{
		return null;
	}

	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0xD307D0", Offset = "0xD2F9D0", VA = "0x180D307D0")]
	public static Handle Solo_skip(int _chapter_)
	{
		return null;
	}

	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0xD30460", Offset = "0xD2F660", VA = "0x180D30460")]
	public static Handle Solo_gate_entry(int _gate_)
	{
		return null;
	}

	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0xD2B270", Offset = "0xD2A470", VA = "0x180D2B270")]
	public static Handle PresentBox_get_list()
	{
		return null;
	}

	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0xD2B2F0", Offset = "0xD2A4F0", VA = "0x180D2B2F0")]
	public static Handle PresentBox_receive(int _present_box_id_, int _is_all_)
	{
		return null;
	}

	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0xD25FD0", Offset = "0xD251D0", VA = "0x180D25FD0")]
	public static Handle DuelMenu_info()
	{
		return null;
	}

	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0xD25E30", Offset = "0xD25030", VA = "0x180D25E30")]
	public static Handle DuelMenu_deck_check(int _kind_, int _tid_, int _regulation_id_)
	{
		return null;
	}

	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0xD2AF10", Offset = "0xD2A110", VA = "0x180D2AF10")]
	public static Handle Notification_get_list()
	{
		return null;
	}

	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0xD2AF90", Offset = "0xD2A190", VA = "0x180D2AF90")]
	public static Handle Notification_read(int _id_)
	{
		return null;
	}

	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0xD1E150", Offset = "0xD1D350", VA = "0x180D1E150")]
	public static Handle Announce_get_list()
	{
		return null;
	}

	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0xD27900", Offset = "0xD26B00", VA = "0x180D27900")]
	public static Handle EventNotify_get_list()
	{
		return null;
	}

	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0xD27770", Offset = "0xD26970", VA = "0x180D27770")]
	public static Handle EventNotify_delete_badge(int _type_, int _subtype_, int[] _target_list_)
	{
		return null;
	}

	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0xD1FE80", Offset = "0xD1F080", VA = "0x180D1FE80")]
	public static Handle Billing_product_list()
	{
		return null;
	}

	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0xD20600", Offset = "0xD1F800", VA = "0x180D20600")]
	public static Handle Billing_reservation(int _shop_id_, int _merchID_, string _price_, string _currency_)
	{
		return null;
	}

	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0xD1E530", Offset = "0xD1D730", VA = "0x180D1E530")]
	public static Handle Billing_Nx_reservation(int _merchID_, string _price_, string _currency_)
	{
		return null;
	}

	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0xD1F750", Offset = "0xD1E950", VA = "0x180D1F750")]
	public static Handle Billing_XBox_reservation(int _merchID_, string _price_, string _currency_)
	{
		return null;
	}

	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0xD1EDD0", Offset = "0xD1DFD0", VA = "0x180D1EDD0")]
	public static Handle Billing_PS_reservation(int _merchID_, string _price_, string _currency_)
	{
		return null;
	}

	[Token(Token = "0x6000E00")]
	[Address(RVA = "0xD1FF00", Offset = "0xD1F100", VA = "0x180D1FF00")]
	public static Handle Billing_purchase(string _receipt_, string _adid_, string _idfa_, string _idfv_, string _gps_adid_)
	{
		return null;
	}

	[Token(Token = "0x6000E01")]
	[Address(RVA = "0xD20130", Offset = "0xD1F330", VA = "0x180D20130")]
	public static Handle Billing_purchase(string _receipt_, string _orderid_, string _transactionid_)
	{
		return null;
	}

	[Token(Token = "0x6000E02")]
	[Address(RVA = "0xD1E2F0", Offset = "0xD1D4F0", VA = "0x180D1E2F0")]
	public static Handle Billing_Nx_purchase()
	{
		return null;
	}

	[Token(Token = "0x6000E03")]
	[Address(RVA = "0xD1F3B0", Offset = "0xD1E5B0", VA = "0x180D1F3B0")]
	public static Handle Billing_XBox_purchase()
	{
		return null;
	}

	[Token(Token = "0x6000E04")]
	[Address(RVA = "0xD1EA00", Offset = "0xD1DC00", VA = "0x180D1EA00")]
	public static Handle Billing_PS_purchase()
	{
		return null;
	}

	[Token(Token = "0x6000E05")]
	[Address(RVA = "0xD1FA50", Offset = "0xD1EC50", VA = "0x180D1FA50")]
	public static Handle Billing_cancel()
	{
		return null;
	}

	[Token(Token = "0x6000E06")]
	[Address(RVA = "0xD20310", Offset = "0xD1F510", VA = "0x180D20310")]
	public static Handle Billing_re_store(string _receipt_)
	{
		return null;
	}

	[Token(Token = "0x6000E07")]
	[Address(RVA = "0xD1F0D0", Offset = "0xD1E2D0", VA = "0x180D1F0D0")]
	public static Handle Billing_Steam_re_store(long _orderid_, long _transactionid_)
	{
		return null;
	}

	[Token(Token = "0x6000E08")]
	[Address(RVA = "0xD1E410", Offset = "0xD1D610", VA = "0x180D1E410")]
	public static Handle Billing_Nx_re_store()
	{
		return null;
	}

	[Token(Token = "0x6000E09")]
	[Address(RVA = "0xD1F4D0", Offset = "0xD1E6D0", VA = "0x180D1F4D0")]
	public static Handle Billing_XBox_re_store(string _tracking_id_, int _merchID_, string _product_id_, string _price_, string _currency_, bool _is_un_complete_add_item_)
	{
		return null;
	}

	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0xD1EB20", Offset = "0xD1DD20", VA = "0x180D1EB20")]
	public static Handle Billing_PS_re_store(string _transaction_id_, int _merchID_, string _product_id_, string _entitlement_label_, string _price_, string _currency_, bool _is_un_complete_add_item_)
	{
		return null;
	}

	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0xD1E710", Offset = "0xD1D910", VA = "0x180D1E710")]
	public static Handle Billing_PS_add_incentive_item(string _transaction_id_, int _ps_incentive_id_, string _product_id_, string _entitlement_label_, int _service_label_)
	{
		return null;
	}

	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0xD20480", Offset = "0xD1F680", VA = "0x180D20480")]
	public static Handle Billing_register_age(int _age_reg_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0xD1F930", Offset = "0xD1EB30", VA = "0x180D1F930")]
	public static Handle Billing_add_purchased_item()
	{
		return null;
	}

	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0xD1FD60", Offset = "0xD1EF60", VA = "0x180D1FD60")]
	public static Handle Billing_in_complete_item_check()
	{
		return null;
	}

	[Token(Token = "0x6000E0F")]
	[Address(RVA = "0xD1EFB0", Offset = "0xD1E1B0", VA = "0x180D1EFB0")]
	public static Handle Billing_Steam_in_complete_item_check()
	{
		return null;
	}

	[Token(Token = "0x6000E10")]
	[Address(RVA = "0xD1E1D0", Offset = "0xD1D3D0", VA = "0x180D1E1D0")]
	public static Handle Billing_Nx_in_complete_item_check()
	{
		return null;
	}

	[Token(Token = "0x6000E11")]
	[Address(RVA = "0xD1F290", Offset = "0xD1E490", VA = "0x180D1F290")]
	public static Handle Billing_XBox_in_complete_item_check()
	{
		return null;
	}

	[Token(Token = "0x6000E12")]
	[Address(RVA = "0xD1E8E0", Offset = "0xD1DAE0", VA = "0x180D1E8E0")]
	public static Handle Billing_PS_in_complete_item_check()
	{
		return null;
	}

	[Token(Token = "0x6000E13")]
	[Address(RVA = "0xD1FB70", Offset = "0xD1ED70", VA = "0x180D1FB70")]
	public static Handle Billing_history(string _month_, int _page_, int _page_count_)
	{
		return null;
	}

	[Token(Token = "0x6000E14")]
	[Address(RVA = "0xD21290", Offset = "0xD20490", VA = "0x180D21290")]
	public static Handle Cgdb_deck_search_init()
	{
		return null;
	}

	[Token(Token = "0x6000E15")]
	[Address(RVA = "0xD21310", Offset = "0xD20510", VA = "0x180D21310")]
	public static Handle Cgdb_deck_search(int _typeCode_, int[] _categoryList_, int[] _tagList_, int[] _cardIdList_, string _keyword_, string _deckCode_, int _sortCode_, int _sizePerPage_, int _requestPageNo_)
	{
		return null;
	}

	[Token(Token = "0x6000E16")]
	[Address(RVA = "0xD21150", Offset = "0xD20350", VA = "0x180D21150")]
	public static Handle Cgdb_deck_search_detail(string _targetId_, int _deckNo_)
	{
		return null;
	}

	[Token(Token = "0x6000E17")]
	[Address(RVA = "0xD21700", Offset = "0xD20900", VA = "0x180D21700")]
	public static Handle Cgdb_mydeck_search(string _userToken_, int _sortCode_, int _sizePerPage_, int _requestPageNo_)
	{
		return null;
	}

	[Token(Token = "0x6000E18")]
	[Address(RVA = "0xD215C0", Offset = "0xD207C0", VA = "0x180D215C0")]
	public static Handle Cgdb_mydeck_search_detail(string _userToken_, int _deckNo_)
	{
		return null;
	}

	[Token(Token = "0x6000E19")]
	[Address(RVA = "0xD2E620", Offset = "0xD2D820", VA = "0x180D2E620")]
	public static Handle Room_room_create(Dictionary<string, object> _room_settings_)
	{
		return null;
	}

	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0xD2E720", Offset = "0xD2D920", VA = "0x180D2E720")]
	public static Handle Room_room_create(Dictionary<string, object> _room_settings_, string _context_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0xD2EA00", Offset = "0xD2DC00", VA = "0x180D2EA00")]
	public static Handle Room_room_entry(int _id_, int _is_specter_, Dictionary<string, object> _options_)
	{
		return null;
	}

	[Token(Token = "0x6000E1C")]
	[Address(RVA = "0xD2E850", Offset = "0xD2DA50", VA = "0x180D2E850")]
	public static Handle Room_room_entry(int _id_, int _is_specter_, Dictionary<string, object> _options_, string _context_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E1D")]
	[Address(RVA = "0xD2EB90", Offset = "0xD2DD90", VA = "0x180D2EB90")]
	public static Handle Room_room_exit()
	{
		return null;
	}

	[Token(Token = "0x6000E1E")]
	[Address(RVA = "0xD2E3C0", Offset = "0xD2D5C0", VA = "0x180D2E3C0")]
	public static Handle Room_get_room_list(Dictionary<string, object> _search_options_)
	{
		return null;
	}

	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0xD2EFD0", Offset = "0xD2E1D0", VA = "0x180D2EFD0")]
	public static Handle Room_table_arrive(int _table_no_)
	{
		return null;
	}

	[Token(Token = "0x6000E20")]
	[Address(RVA = "0xD2F0E0", Offset = "0xD2E2E0", VA = "0x180D2F0E0")]
	public static Handle Room_table_leave()
	{
		return null;
	}

	[Token(Token = "0x6000E21")]
	[Address(RVA = "0xD2ED40", Offset = "0xD2DF40", VA = "0x180D2ED40")]
	public static Handle Room_room_friend_invite(long[] _invite_list_)
	{
		return null;
	}

	[Token(Token = "0x6000E22")]
	[Address(RVA = "0xD2EC10", Offset = "0xD2DE10", VA = "0x180D2EC10")]
	public static Handle Room_room_friend_invite(long[] _invite_list_, string _context_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E23")]
	[Address(RVA = "0xD2EE40", Offset = "0xD2E040", VA = "0x180D2EE40")]
	public static Handle Room_room_table_polling()
	{
		return null;
	}

	[Token(Token = "0x6000E24")]
	[Address(RVA = "0xD2E4C0", Offset = "0xD2D6C0", VA = "0x180D2E4C0")]
	public static Handle Room_is_room_battle_ready(bool _isBattleReady_, long _opp_pcode_)
	{
		return null;
	}

	[Token(Token = "0x6000E25")]
	[Address(RVA = "0xD2EEC0", Offset = "0xD2E0C0", VA = "0x180D2EEC0")]
	public static Handle Room_set_user_comment(int _comment_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E26")]
	[Address(RVA = "0xD2E340", Offset = "0xD2D540", VA = "0x180D2E340")]
	public static Handle Room_get_result_list()
	{
		return null;
	}

	[Token(Token = "0x6000E27")]
	[Address(RVA = "0xD28130", Offset = "0xD27330", VA = "0x180D28130")]
	public static Handle Exhibition_detail(int _exhid_)
	{
		return null;
	}

	[Token(Token = "0x6000E28")]
	[Address(RVA = "0xD28240", Offset = "0xD27440", VA = "0x180D28240")]
	public static Handle Exhibition_duel_history(int _exhid_)
	{
		return null;
	}

	[Token(Token = "0x6000E29")]
	[Address(RVA = "0xD28740", Offset = "0xD27940", VA = "0x180D28740")]
	public static Handle Exhibition_set_deck(int _exhid_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0xD28600", Offset = "0xD27800", VA = "0x180D28600")]
	public static Handle Exhibition_set_deck_accessory(int _exhid_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0xD28020", Offset = "0xD27220", VA = "0x180D28020")]
	public static Handle Exhibition_delete_deck(int _exhid_)
	{
		return null;
	}

	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0xD27F10", Offset = "0xD27110", VA = "0x180D27F10")]
	public static Handle Exhibition_copy_to_deck(int _exhid_)
	{
		return null;
	}

	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0xD284B0", Offset = "0xD276B0", VA = "0x180D284B0")]
	public static Handle Exhibition_rental_deck_detail(int _exhid_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0xD27DC0", Offset = "0xD26FC0", VA = "0x180D27DC0")]
	public static Handle Exhibition_copy_rental_deck(int _exhid_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0xD288E0", Offset = "0xD27AE0", VA = "0x180D288E0")]
	public static Handle Exhibition_set_use_deck(int _exhid_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000E30")]
	[Address(RVA = "0xD28350", Offset = "0xD27550", VA = "0x180D28350")]
	public static Handle Exhibition_get_deck_list(int _exhid_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000E31")]
	[Address(RVA = "0xD274A0", Offset = "0xD266A0", VA = "0x180D274A0")]
	public static Handle Duelpass_get_info()
	{
		return null;
	}

	[Token(Token = "0x6000E32")]
	[Address(RVA = "0xD27360", Offset = "0xD26560", VA = "0x180D27360")]
	public static Handle Duelpass_bulk_receive(int _season_id_, int[] _reward_id_list_)
	{
		return null;
	}

	[Token(Token = "0x6000E33")]
	[Address(RVA = "0xD25B90", Offset = "0xD24D90", VA = "0x180D25B90")]
	public static Handle DuelLive_replay_list(int _menu_id_, int _section_id_, int _opt_)
	{
		return null;
	}

	[Token(Token = "0x6000E34")]
	[Address(RVA = "0xD25980", Offset = "0xD24B80", VA = "0x180D25980")]
	public static Handle DuelLive_replay_duel(int _menu_id_, int _idx_, int _opt_, int _mrk_, int _reverse_)
	{
		return null;
	}

	[Token(Token = "0x6000E35")]
	[Address(RVA = "0xD257A0", Offset = "0xD249A0", VA = "0x180D257A0")]
	public static Handle DuelLive_get_replay_deck(int _menu_id_, int _mrk_, int _idx_, int _reverse_)
	{
		return null;
	}

	[Token(Token = "0x6000E36")]
	[Address(RVA = "0xD25D30", Offset = "0xD24F30", VA = "0x180D25D30")]
	public static Handle DuelLive_visit(Dictionary<string, object>[] _menu_ids_)
	{
		return null;
	}

	[Token(Token = "0x6000E37")]
	[Address(RVA = "0xD27520", Offset = "0xD26720", VA = "0x180D27520")]
	public static Handle Enquete_get_questions(int _enquete_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E38")]
	[Address(RVA = "0xD27630", Offset = "0xD26830", VA = "0x180D27630")]
	public static Handle Enquete_send_answers(int _enquete_id_, Dictionary<string, object> _results_)
	{
		return null;
	}

	[Token(Token = "0x6000E39")]
	[Address(RVA = "0xD2CAE0", Offset = "0xD2BCE0", VA = "0x180D2CAE0")]
	public static Handle RankEvent_detail(int _rank_event_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0xD2CBF0", Offset = "0xD2BDF0", VA = "0x180D2CBF0")]
	public static Handle RankEvent_duel_history(int _rank_event_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E3B")]
	[Address(RVA = "0xD2CE60", Offset = "0xD2C060", VA = "0x180D2CE60")]
	public static Handle RankEvent_reward_list(int _rank_event_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0xD2CD00", Offset = "0xD2BF00", VA = "0x180D2CD00")]
	public static Handle RankEvent_get_deck_list(int _rank_event_id_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0xD2D0B0", Offset = "0xD2C2B0", VA = "0x180D2D0B0")]
	public static Handle RankEvent_set_deck(int _rank_event_id_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0xD2CF70", Offset = "0xD2C170", VA = "0x180D2CF70")]
	public static Handle RankEvent_set_deck_accessory(int _rank_event_id_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0xD2C9D0", Offset = "0xD2BBD0", VA = "0x180D2C9D0")]
	public static Handle RankEvent_delete_deck(int _rank_event_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E40")]
	[Address(RVA = "0xD22B70", Offset = "0xD21D70", VA = "0x180D22B70")]
	public static Handle Cup_detail(int _cid_)
	{
		return null;
	}

	[Token(Token = "0x6000E41")]
	[Address(RVA = "0xD22D90", Offset = "0xD21F90", VA = "0x180D22D90")]
	public static Handle Cup_get_deck_list(int _cid_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000E42")]
	[Address(RVA = "0xD23140", Offset = "0xD22340", VA = "0x180D23140")]
	public static Handle Cup_set_deck(int _cid_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000E43")]
	[Address(RVA = "0xD22A60", Offset = "0xD21C60", VA = "0x180D22A60")]
	public static Handle Cup_delete_deck(int _cid_)
	{
		return null;
	}

	[Token(Token = "0x6000E44")]
	[Address(RVA = "0xD22C80", Offset = "0xD21E80", VA = "0x180D22C80")]
	public static Handle Cup_duel_history(int _cid_)
	{
		return null;
	}

	[Token(Token = "0x6000E45")]
	[Address(RVA = "0xD23000", Offset = "0xD22200", VA = "0x180D23000")]
	public static Handle Cup_set_deck_accessory(int _cid_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000E46")]
	[Address(RVA = "0xD22EF0", Offset = "0xD220F0", VA = "0x180D22EF0")]
	public static Handle Cup_get_ranking(int _cid_)
	{
		return null;
	}

	[Token(Token = "0x6000E47")]
	[Address(RVA = "0xD20C70", Offset = "0xD1FE70", VA = "0x180D20C70")]
	public static Handle CardTermData_get_list()
	{
		return null;
	}

	[Token(Token = "0x6000E48")]
	[Address(RVA = "0xD31030", Offset = "0xD30230", VA = "0x180D31030")]
	public static Handle Team_set_team_regulation_group_id(int _team_regulation_group_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E49")]
	[Address(RVA = "0xD312D0", Offset = "0xD304D0", VA = "0x180D312D0")]
	public static Handle Team_team_create(Dictionary<string, object> _team_settings_, int _team_match_type_)
	{
		return null;
	}

	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0xD31410", Offset = "0xD30610", VA = "0x180D31410")]
	public static Handle Team_team_create(Dictionary<string, object> _team_settings_, int _team_match_type_, string _context_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0xD31EA0", Offset = "0xD310A0", VA = "0x180D31EA0")]
	public static Handle Team_team_exit()
	{
		return null;
	}

	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0xD31BC0", Offset = "0xD30DC0", VA = "0x180D31BC0")]
	public static Handle Team_team_entry(int _team_id_, int _team_match_type_)
	{
		return null;
	}

	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0xD31D10", Offset = "0xD30F10", VA = "0x180D31D10")]
	public static Handle Team_team_entry(int _team_id_, int _team_match_type_, string _context_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0xD31860", Offset = "0xD30A60", VA = "0x180D31860")]
	public static Handle Team_team_entry_and_arrive(int _team_id_, int _team_match_type_, int _table_no_)
	{
		return null;
	}

	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0xD31A00", Offset = "0xD30C00", VA = "0x180D31A00")]
	public static Handle Team_team_entry_and_arrive(int _team_id_, int _team_match_type_, string _context_id_, int _table_no_)
	{
		return null;
	}

	[Token(Token = "0x6000E50")]
	[Address(RVA = "0xD32050", Offset = "0xD31250", VA = "0x180D32050")]
	public static Handle Team_team_invite(long[] _invite_list_)
	{
		return null;
	}

	[Token(Token = "0x6000E51")]
	[Address(RVA = "0xD31F20", Offset = "0xD31120", VA = "0x180D31F20")]
	public static Handle Team_team_invite(long[] _invite_list_, string _context_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E52")]
	[Address(RVA = "0xD32260", Offset = "0xD31460", VA = "0x180D32260")]
	public static Handle Team_team_recruit(int _num_)
	{
		return null;
	}

	[Token(Token = "0x6000E53")]
	[Address(RVA = "0xD323F0", Offset = "0xD315F0", VA = "0x180D323F0")]
	public static Handle Team_team_search(int _num_, bool _cancel_flg_)
	{
		return null;
	}

	[Token(Token = "0x6000E54")]
	[Address(RVA = "0xD32150", Offset = "0xD31350", VA = "0x180D32150")]
	public static Handle Team_team_polling(int _team_match_type_)
	{
		return null;
	}

	[Token(Token = "0x6000E55")]
	[Address(RVA = "0xD32370", Offset = "0xD31570", VA = "0x180D32370")]
	public static Handle Team_team_result_polling()
	{
		return null;
	}

	[Token(Token = "0x6000E56")]
	[Address(RVA = "0xD31140", Offset = "0xD30340", VA = "0x180D31140")]
	public static Handle Team_table_arrive(int _table_no_)
	{
		return null;
	}

	[Token(Token = "0x6000E57")]
	[Address(RVA = "0xD31250", Offset = "0xD30450", VA = "0x180D31250")]
	public static Handle Team_table_leave()
	{
		return null;
	}

	[Token(Token = "0x6000E58")]
	[Address(RVA = "0xD30F20", Offset = "0xD30120", VA = "0x180D30F20")]
	public static Handle Team_post_comment(int _comment_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E59")]
	[Address(RVA = "0xD31710", Offset = "0xD30910", VA = "0x180D31710")]
	public static Handle Team_team_duel_request(int _team_id_, int _duel_time_)
	{
		return null;
	}

	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0xD31690", Offset = "0xD30890", VA = "0x180D31690")]
	public static Handle Team_team_duel_request_cancel()
	{
		return null;
	}

	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0xD31580", Offset = "0xD30780", VA = "0x180D31580")]
	public static Handle Team_team_duel_reply(bool _reply_)
	{
		return null;
	}

	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0xD261A0", Offset = "0xD253A0", VA = "0x180D261A0")]
	public static Handle DuelTrial_detail(int _duel_trial_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E5D")]
	[Address(RVA = "0xD262B0", Offset = "0xD254B0", VA = "0x180D262B0")]
	public static Handle DuelTrial_duel_history(int _duel_trial_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0xD263C0", Offset = "0xD255C0", VA = "0x180D263C0")]
	public static Handle DuelTrial_get_deck_list(int _duel_trial_id_, int _idx_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0xD269E0", Offset = "0xD25BE0", VA = "0x180D269E0")]
	public static Handle DuelTrial_set_deck(int _duel_trial_id_, int _idx_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000E60")]
	[Address(RVA = "0xD26850", Offset = "0xD25A50", VA = "0x180D26850")]
	public static Handle DuelTrial_set_deck_accessory(int _duel_trial_id_, int _idx_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000E61")]
	[Address(RVA = "0xD26050", Offset = "0xD25250", VA = "0x180D26050")]
	public static Handle DuelTrial_delete_deck(int _duel_trial_id_, int _idx_)
	{
		return null;
	}

	[Token(Token = "0x6000E62")]
	[Address(RVA = "0xD26BB0", Offset = "0xD25DB0", VA = "0x180D26BB0")]
	public static Handle DuelTrial_set_use_deck(int _duel_trial_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000E63")]
	[Address(RVA = "0xD26560", Offset = "0xD25760", VA = "0x180D26560")]
	public static Handle DuelTrial_get_rental_deck_list(int _duel_trial_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000E64")]
	[Address(RVA = "0xD266B0", Offset = "0xD258B0", VA = "0x180D266B0")]
	public static Handle DuelTrial_receive_bonus(int _duel_trial_id_, int _item_id_, int _num_)
	{
		return null;
	}

	[Token(Token = "0x6000E65")]
	[Address(RVA = "0xD2B440", Offset = "0xD2A640", VA = "0x180D2B440")]
	public static Handle PromoCodes_send_code(int _promo_codes_id_, string _send_code_, string _check_code_)
	{
		return null;
	}

	[Token(Token = "0x6000E66")]
	[Address(RVA = "0xD35320", Offset = "0xD34520", VA = "0x180D35320")]
	public static Handle Wcs_detail(int _wcs_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E67")]
	[Address(RVA = "0xD35540", Offset = "0xD34740", VA = "0x180D35540")]
	public static Handle Wcs_get_deck_list(int _wcs_id_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000E68")]
	[Address(RVA = "0xD35A90", Offset = "0xD34C90", VA = "0x180D35A90")]
	public static Handle Wcs_set_deck(int _wcs_id_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000E69")]
	[Address(RVA = "0xD35070", Offset = "0xD34270", VA = "0x180D35070")]
	public static Handle Wcs_delete_deck(int _wcs_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0xD35430", Offset = "0xD34630", VA = "0x180D35430")]
	public static Handle Wcs_duel_history(int _wcs_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0xD35950", Offset = "0xD34B50", VA = "0x180D35950")]
	public static Handle Wcs_set_deck_accessory(int _wcs_id_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0xD35840", Offset = "0xD34A40", VA = "0x180D35840")]
	public static Handle Wcs_get_ranking(int _wcs_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0xD36480", Offset = "0xD35680", VA = "0x180D36480")]
	public static Handle Wcs_set_region(int _wcs_id_, int _region_)
	{
		return null;
	}

	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0xD357C0", Offset = "0xD349C0", VA = "0x180D357C0")]
	public static Handle Wcs_get_participation()
	{
		return null;
	}

	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0xD34F60", Offset = "0xD34160", VA = "0x180D34F60")]
	public static Handle Wcs_confirm_participation(int _id_)
	{
		return null;
	}

	[Token(Token = "0x6000E70")]
	[Address(RVA = "0xD356A0", Offset = "0xD348A0", VA = "0x180D356A0")]
	public static Handle Wcs_get_final_deck_info()
	{
		return null;
	}

	[Token(Token = "0x6000E71")]
	[Address(RVA = "0xD35C30", Offset = "0xD34E30", VA = "0x180D35C30")]
	public static Handle Wcs_set_final_deck(int _wcs_id_, int _member_idx_, int _slot_, string _name_, Dictionary<string, object> _deck_list_)
	{
		return null;
	}

	[Token(Token = "0x6000E72")]
	[Address(RVA = "0xD35180", Offset = "0xD34380", VA = "0x180D35180")]
	public static Handle Wcs_delete_final_deck(int _wcs_id_, int _member_idx_, int _slot_)
	{
		return null;
	}

	[Token(Token = "0x6000E73")]
	[Address(RVA = "0xD36200", Offset = "0xD35400", VA = "0x180D36200")]
	public static Handle Wcs_set_final_share_card(int _wcs_id_, Dictionary<string, object> _share_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000E74")]
	[Address(RVA = "0xD34D40", Offset = "0xD33F40", VA = "0x180D34D40")]
	public static Handle Wcs_check_final_deck_regulation(int _wcs_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E75")]
	[Address(RVA = "0xD34E50", Offset = "0xD34050", VA = "0x180D34E50")]
	public static Handle Wcs_complete_final_deck(int _wcs_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E76")]
	[Address(RVA = "0xD365D0", Offset = "0xD357D0", VA = "0x180D365D0")]
	public static Handle Wcs_unregister_final_deck(int _wcs_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E77")]
	[Address(RVA = "0xD35E20", Offset = "0xD35020", VA = "0x180D35E20")]
	public static Handle Wcs_set_final_member_name(int _wcs_id_, string _name_)
	{
		return null;
	}

	[Token(Token = "0x6000E78")]
	[Address(RVA = "0xD35F60", Offset = "0xD35160", VA = "0x180D35F60")]
	public static Handle Wcs_set_final_member_profile(int _wcs_id_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000E79")]
	[Address(RVA = "0xD36340", Offset = "0xD35540", VA = "0x180D36340")]
	public static Handle Wcs_set_final_team_name(int _wcs_id_, string _name_)
	{
		return null;
	}

	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0xD360A0", Offset = "0xD352A0", VA = "0x180D360A0")]
	public static Handle Wcs_set_final_member_status(int _wcs_id_, bool _is_regist_)
	{
		return null;
	}

	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0xD33A90", Offset = "0xD32C90", VA = "0x180D33A90")]
	public static Handle Versus_detail(int _versus_id_, int _set_group_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0xD33BE0", Offset = "0xD32DE0", VA = "0x180D33BE0")]
	public static Handle Versus_duel_history(int _versus_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0xD33CF0", Offset = "0xD32EF0", VA = "0x180D33CF0")]
	public static Handle Versus_get_deck_list(int _versus_id_, int _idx_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0xD34170", Offset = "0xD33370", VA = "0x180D34170")]
	public static Handle Versus_set_deck(int _versus_id_, int _idx_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0xD33FE0", Offset = "0xD331E0", VA = "0x180D33FE0")]
	public static Handle Versus_set_deck_accessory(int _versus_id_, int _idx_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000E80")]
	[Address(RVA = "0xD33940", Offset = "0xD32B40", VA = "0x180D33940")]
	public static Handle Versus_delete_deck(int _versus_id_, int _idx_)
	{
		return null;
	}

	[Token(Token = "0x6000E81")]
	[Address(RVA = "0xD34340", Offset = "0xD33540", VA = "0x180D34340")]
	public static Handle Versus_set_use_deck(int _versus_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000E82")]
	[Address(RVA = "0xD33E90", Offset = "0xD33090", VA = "0x180D33E90")]
	public static Handle Versus_get_rental_deck_list(int _versus_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000E83")]
	[Address(RVA = "0xD34A60", Offset = "0xD33C60", VA = "0x180D34A60")]
	public static Handle WcsFinal_table_polling()
	{
		return null;
	}

	[Token(Token = "0x6000E84")]
	[Address(RVA = "0xD34720", Offset = "0xD33920", VA = "0x180D34720")]
	public static Handle WcsFinal_is_duel_ready(bool _isReady_, long _opp_pcode_, int _tno_)
	{
		return null;
	}

	[Token(Token = "0x6000E85")]
	[Address(RVA = "0xD34590", Offset = "0xD33790", VA = "0x180D34590")]
	public static Handle WcsFinal_ad_table_polling(int _room_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E86")]
	[Address(RVA = "0xD34510", Offset = "0xD33710", VA = "0x180D34510")]
	public static Handle WcsFinal_ad_primary_polling()
	{
		return null;
	}

	[Token(Token = "0x6000E87")]
	[Address(RVA = "0xD34490", Offset = "0xD33690", VA = "0x180D34490")]
	public static Handle WcsFinal_ad_final_polling()
	{
		return null;
	}

	[Token(Token = "0x6000E88")]
	[Address(RVA = "0xD34B60", Offset = "0xD33D60", VA = "0x180D34B60")]
	public static Handle WcsFinal_user_home()
	{
		return null;
	}

	[Token(Token = "0x6000E89")]
	[Address(RVA = "0xD34AE0", Offset = "0xD33CE0", VA = "0x180D34AE0")]
	public static Handle WcsFinal_user_entry()
	{
		return null;
	}

	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0xD346A0", Offset = "0xD338A0", VA = "0x180D346A0")]
	public static Handle WcsFinal_duel_menu_info()
	{
		return null;
	}

	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0xD34BE0", Offset = "0xD33DE0", VA = "0x180D34BE0")]
	public static Handle WcsFinal_watch_duel(long _pcode_, long _rapid_)
	{
		return null;
	}

	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0xD348C0", Offset = "0xD33AC0", VA = "0x180D348C0")]
	public static Handle WcsFinal_replay_duel_history(long _did_, long _pcode_, bool _is_open_)
	{
		return null;
	}

	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0xD36760", Offset = "0xD35960", VA = "0x180D36760")]
	public static Handle WcsfCampaign_info()
	{
		return null;
	}

	[Token(Token = "0x6000E8E")]
	[Address(RVA = "0xD367E0", Offset = "0xD359E0", VA = "0x180D367E0")]
	public static Handle WcsfCampaign_primary_polling()
	{
		return null;
	}

	[Token(Token = "0x6000E8F")]
	[Address(RVA = "0xD366E0", Offset = "0xD358E0", VA = "0x180D366E0")]
	public static Handle WcsfCampaign_final_polling()
	{
		return null;
	}

	[Token(Token = "0x6000E90")]
	[Address(RVA = "0xD36B50", Offset = "0xD35D50", VA = "0x180D36B50")]
	public static Handle WcsfCampaign_table_polling(int _room_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E91")]
	[Address(RVA = "0xD36C60", Offset = "0xD35E60", VA = "0x180D36C60")]
	public static Handle WcsfCampaign_watch_duel(long _pcode_, long _rapid_)
	{
		return null;
	}

	[Token(Token = "0x6000E92")]
	[Address(RVA = "0xD369C0", Offset = "0xD35BC0", VA = "0x180D369C0")]
	public static Handle WcsfCampaign_set_support_team(int _team_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E93")]
	[Address(RVA = "0xD36AD0", Offset = "0xD35CD0", VA = "0x180D36AD0")]
	public static Handle WcsfCampaign_support_entry()
	{
		return null;
	}

	[Token(Token = "0x6000E94")]
	[Address(RVA = "0xD36860", Offset = "0xD35A60", VA = "0x180D36860")]
	public static Handle WcsfCampaign_replay_duel(long _did_, long _pcode_)
	{
		return null;
	}

	[Token(Token = "0x6000E95")]
	[Address(RVA = "0xD20EF0", Offset = "0xD200F0", VA = "0x180D20EF0")]
	public static Handle Certification_detail(int _certification_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E96")]
	[Address(RVA = "0xD21000", Offset = "0xD20200", VA = "0x180D21000")]
	public static Handle Certification_get_academic_exam(int _certification_id_, int _grade_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E97")]
	[Address(RVA = "0xD20DF0", Offset = "0xD1FFF0", VA = "0x180D20DF0")]
	public static Handle Certification_check_quiz_answers(int[] _answers_)
	{
		return null;
	}

	[Token(Token = "0x6000E98")]
	[Address(RVA = "0xD30EA0", Offset = "0xD300A0", VA = "0x180D30EA0")]
	public static Handle Tdy_detail()
	{
		return null;
	}

	[Token(Token = "0x6000E99")]
	[Address(RVA = "0xD2F450", Offset = "0xD2E650", VA = "0x180D2F450")]
	public static Handle SeasonPt_id_search(int _idx_, long _pcode_)
	{
		return null;
	}

	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0xD2F5B0", Offset = "0xD2E7B0", VA = "0x180D2F5B0")]
	public static Handle SeasonPt_info(bool _is_back_)
	{
		return null;
	}

	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0xD2F6C0", Offset = "0xD2E8C0", VA = "0x180D2F6C0")]
	public static Handle SeasonPt_team_create(long _member1_pcode_, long _member2_pcode_, int _region_)
	{
		return null;
	}

	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0xD2F860", Offset = "0xD2EA60", VA = "0x180D2F860")]
	public static Handle SeasonPt_team_disband(int _unique_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0xD2F970", Offset = "0xD2EB70", VA = "0x180D2F970")]
	public static Handle SeasonPt_team_member_status(int _unique_id_, int _action_)
	{
		return null;
	}

	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0xD2FAC0", Offset = "0xD2ECC0", VA = "0x180D2FAC0")]
	public static Handle SeasonPt_team_search(int _unique_id_)
	{
		return null;
	}

	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0xD2F1E0", Offset = "0xD2E3E0", VA = "0x180D2F1E0")]
	public static Handle SeasonPt_get_record(bool _is_own_, int _unique_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0xD2F160", Offset = "0xD2E360", VA = "0x180D2F160")]
	public static Handle SeasonPt_get_ranking()
	{
		return null;
	}

	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0xD2F340", Offset = "0xD2E540", VA = "0x180D2F340")]
	public static Handle SeasonPt_get_result(int _season_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0xD2FBD0", Offset = "0xD2EDD0", VA = "0x180D2FBD0")]
	public static Handle SeasonPt_update_demand_status(int _status_)
	{
		return null;
	}

	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0xD29B10", Offset = "0xD28D10", VA = "0x180D29B10")]
	public static Handle Invitation_send_code(int _invitation_id_, string _send_code_, string _check_code_)
	{
		return null;
	}

	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0xD298F0", Offset = "0xD28AF0", VA = "0x180D298F0")]
	public static Handle Invitation_get_info_for_invitee(int _invitation_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0xD29A00", Offset = "0xD28C00", VA = "0x180D29A00")]
	public static Handle Invitation_get_info_for_inviter(int _invitation_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EA6")]
	[Address(RVA = "0xD2D250", Offset = "0xD2C450", VA = "0x180D2D250")]
	public static Handle RateDuel_detail(int _season_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EA7")]
	[Address(RVA = "0xD2D360", Offset = "0xD2C560", VA = "0x180D2D360")]
	public static Handle RateDuel_duel_history(int _season_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0xD2D470", Offset = "0xD2C670", VA = "0x180D2D470")]
	public static Handle RateDuel_get_ranking(int _season_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0xD2D6D0", Offset = "0xD2C8D0", VA = "0x180D2D6D0")]
	public static Handle RateDuel_set_use_deck(int _season_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0xD2D580", Offset = "0xD2C780", VA = "0x180D2D580")]
	public static Handle RateDuel_get_rental_deck_list(int _season_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0xD29C80", Offset = "0xD28E80", VA = "0x180D29C80")]
	public static Handle LoginBonusEx_get_info(int _login_bonus_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0xD29D90", Offset = "0xD28F90", VA = "0x180D29D90")]
	public static Handle LoginBonusEx_get_list()
	{
		return null;
	}

	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0xD2A140", Offset = "0xD29340", VA = "0x180D2A140")]
	public static Handle LoginBonusEx_receive(int _login_bonus_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0xD29F60", Offset = "0xD29160", VA = "0x180D29F60")]
	public static Handle LoginBonusEx_purchase(int _login_bonus_id_, int _shop_id_, int _price_id_, int _num_)
	{
		return null;
	}

	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0xD29E10", Offset = "0xD29010", VA = "0x180D29E10")]
	public static Handle LoginBonusEx_get_probability(int _gacha_id_, int _shop_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0xD2D930", Offset = "0xD2CB30", VA = "0x180D2D930")]
	public static Handle Rdc_detail(int _rid_)
	{
		return null;
	}

	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0xD2DB50", Offset = "0xD2CD50", VA = "0x180D2DB50")]
	public static Handle Rdc_get_deck_list(int _rid_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0xD2E050", Offset = "0xD2D250", VA = "0x180D2E050")]
	public static Handle Rdc_set_deck(int _rid_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0xD2D820", Offset = "0xD2CA20", VA = "0x180D2D820")]
	public static Handle Rdc_delete_deck(int _rid_)
	{
		return null;
	}

	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0xD2DA40", Offset = "0xD2CC40", VA = "0x180D2DA40")]
	public static Handle Rdc_duel_history(int _rid_)
	{
		return null;
	}

	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0xD2DF10", Offset = "0xD2D110", VA = "0x180D2DF10")]
	public static Handle Rdc_set_deck_accessory(int _rid_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0xD2DCB0", Offset = "0xD2CEB0", VA = "0x180D2DCB0")]
	public static Handle Rdc_get_ranking(int _rid_)
	{
		return null;
	}

	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0xD2E1F0", Offset = "0xD2D3F0", VA = "0x180D2E1F0")]
	public static Handle Rdc_set_use_deck(int _rid_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0xD2DDC0", Offset = "0xD2CFC0", VA = "0x180D2DDC0")]
	public static Handle Rdc_get_rental_deck_list(int _rid_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0xD24850", Offset = "0xD23A50", VA = "0x180D24850")]
	public static Handle Dicerally_detail(int _dicerally_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0xD24960", Offset = "0xD23B60", VA = "0x180D24960")]
	public static Handle Dicerally_duel_history(int _dicerally_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0xD24BC0", Offset = "0xD23DC0", VA = "0x180D24BC0")]
	public static Handle Dicerally_get_deck_list(int _dicerally_id_, bool _is_empty_get_)
	{
		return null;
	}

	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0xD24FB0", Offset = "0xD241B0", VA = "0x180D24FB0")]
	public static Handle Dicerally_set_deck(int _dicerally_id_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
	{
		return null;
	}

	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0xD24E70", Offset = "0xD24070", VA = "0x180D24E70")]
	public static Handle Dicerally_set_deck_accessory(int _dicerally_id_, Dictionary<string, object> _param_)
	{
		return null;
	}

	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0xD24740", Offset = "0xD23940", VA = "0x180D24740")]
	public static Handle Dicerally_delete_deck(int _dicerally_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0xD25150", Offset = "0xD24350", VA = "0x180D25150")]
	public static Handle Dicerally_set_use_deck(int _dicerally_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0xD24D20", Offset = "0xD23F20", VA = "0x180D24D20")]
	public static Handle Dicerally_get_rental_deck_list(int _dicerally_id_, int _rental_idx_)
	{
		return null;
	}

	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0xD252A0", Offset = "0xD244A0", VA = "0x180D252A0")]
	public static Handle Dicerally_update_board(int _dicerally_id_, int _dice_roll_num_)
	{
		return null;
	}

	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0xD24A70", Offset = "0xD23C70", VA = "0x180D24A70")]
	public static Handle Dicerally_get_card_list(int _dicerally_id_, int _target_gacha_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0xD209D0", Offset = "0xD1FBD0", VA = "0x180D209D0")]
	public static Handle CardFile_get_list(long _pcode_)
	{
		return null;
	}

	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0xD20830", Offset = "0xD1FA30", VA = "0x180D20830")]
	public static Handle CardFile_detail(long _pcode_, int _item_id_, bool _is_open_profile_)
	{
		return null;
	}

	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0xD20AE0", Offset = "0xD1FCE0", VA = "0x180D20AE0")]
	public static Handle CardFile_update_card_order(int _item_id_, int _sort_type_, Dictionary<string, object> _card_list_)
	{
		return null;
	}

	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0xD2A650", Offset = "0xD29850", VA = "0x180D2A650")]
	public static Handle Lottery_portal(int _lottery_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0xD2A3F0", Offset = "0xD295F0", VA = "0x180D2A3F0")]
	public static Handle Lottery_get_card_pool(int _lottery_id_)
	{
		return null;
	}

	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0xD2A250", Offset = "0xD29450", VA = "0x180D2A250")]
	public static Handle Lottery_check_set_round(int _lottery_id_, int _set_, int _round_)
	{
		return null;
	}

	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0xD2A500", Offset = "0xD29700", VA = "0x180D2A500")]
	public static Handle Lottery_get_result(int _lottery_id_, int _set_)
	{
		return null;
	}

	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0xD2A760", Offset = "0xD29960", VA = "0x180D2A760")]
	public static Handle Lottery_set_cards(int _lottery_id_, int _set_, int _round_, int[] _cards_)
	{
		return null;
	}

	[Token(Token = "0x6000ECB")]
	[Address(RVA = "0xD27980", Offset = "0xD26B80", VA = "0x180D27980")]
	public static Handle Exchange_card_exchange_limited(int _exchange_id_, int _num_, int _mrk_, int _premium_)
	{
		return null;
	}

	[Token(Token = "0x6000ECC")]
	[Address(RVA = "0xD27B60", Offset = "0xD26D60", VA = "0x180D27B60")]
	public static Handle Exchange_item_exchange_limited(int _exchange_id_, int _num_)
	{
		return null;
	}

	[Token(Token = "0x6000ECD")]
	[Address(RVA = "0xD27CB0", Offset = "0xD26EB0", VA = "0x180D27CB0")]
	public static Handle Exchange_submenu_exchange(int _exchange_submenu_id_)
	{
		return null;
	}

	[Token(Token = "0x6000ECE")]
	[Address(RVA = "0xD297F0", Offset = "0xD289F0", VA = "0x180D297F0")]
	public static Handle GeneralPool_get_card_list(int[] _card_pool_)
	{
		return null;
	}

	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0xD2AA80", Offset = "0xD29C80", VA = "0x180D2AA80")]
	public static Handle Market_get_data(int _marketId_)
	{
		return null;
	}

	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0xD2A920", Offset = "0xD29B20", VA = "0x180D2A920")]
	public static Handle Market_edit_agree(bool _agree_, bool _formShop_)
	{
		return null;
	}

	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public API()
	{
	}
}
