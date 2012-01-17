using System.Collections.Generic;

namespace WowPacketParser.Enums.Version//.V4_2_2_14545
{
    public static partial class Opcodes
    {
        private static readonly Dictionary<Opcode, int> _V4_2_2_opcodes = new Dictionary<Opcode, int>
        {
            {Opcode.CMSG_ACCEPT_LEVEL_GRANT, 0xDC4B},
            {Opcode.CMSG_ACCEPT_TRADE, 0xB4A5},
            {Opcode.SMSG_TRADE_STATUS_EXTENDED, 0xF0EC},
            {Opcode.CMSG_ACTIVATETAXI, 0x8CDB},
            {Opcode.CMSG_ACTIVATETAXIEXPRESS, 0x5E7F},
            {Opcode.CMSG_ADD_FRIEND, 0x5C57},
            {Opcode.CMSG_ADD_IGNORE, 0xCEEA},
            {Opcode.CMSG_ADD_VOICE_IGNORE, 0xA7A},
            {Opcode.CMSG_ALTER_APPEARANCE, 0x5CE3},
            {Opcode.CMSG_AREATRIGGER, 0x5862},
            {Opcode.CMSG_AREA_SPIRIT_HEALER_QUERY, 0xDC7E},
            {Opcode.CMSG_AREA_SPIRIT_HEALER_QUEUE, 0x8846},
            {Opcode.CMSG_ARENA_TEAM_ACCEPT, 0xDA42},
            {Opcode.CMSG_ARENA_TEAM_DECLINE, 0x8E73},
            {Opcode.CMSG_ARENA_TEAM_DISBAND, 0x4A5A},
            {Opcode.CMSG_ARENA_TEAM_INVITE, 0x4862},
            {Opcode.CMSG_ARENA_TEAM_LEADER, 0x8F3},
            {Opcode.CMSG_ARENA_TEAM_LEAVE, 0x48EB},
            {Opcode.CMSG_ARENA_TEAM_QUERY, 0x872},
            {Opcode.CMSG_ARENA_TEAM_REMOVE, 0xCE5E},
            {Opcode.CMSG_ARENA_TEAM_ROSTER, 0xA42},
            {Opcode.CMSG_ATTACKSTOP, 0x5AC3},
            {Opcode.CMSG_ATTACKSWING, 0xDE66},
            {Opcode.CMSG_AUCTION_LIST_BIDDER_ITEMS, 0x187A},
            {Opcode.CMSG_AUCTION_LIST_ITEMS, 0xDC5F},
            {Opcode.CMSG_AUCTION_LIST_OWNER_ITEMS, 0x9CDA},
            {Opcode.CMSG_AUCTION_PLACE_BID, 0x8E76},
            {Opcode.CMSG_AUCTION_REMOVE_ITEM, 0xCEC3},
            {Opcode.CMSG_AUCTION_SELL_ITEM, 0xCE6},
            {Opcode.CMSG_AUTH_SESSION, 0x1019},
            {Opcode.CMSG_AUTOBANK_ITEM, 0x8C56},
            {Opcode.CMSG_AUTOEQUIP_ITEM, 0x8E66},
            {Opcode.CMSG_AUTOEQUIP_ITEM_SLOT, 0x9E67},
            {Opcode.CMSG_AUTOSTORE_BAG_ITEM, 0x0EEE},
            {Opcode.CMSG_AUTOSTORE_BANK_ITEM, 0x1C5F},
            {Opcode.CMSG_AUTOSTORE_LOOT_ITEM, 0xD876},
            {Opcode.CMSG_BANKER_ACTIVATE, 0xA5A},
            {Opcode.CMSG_AUTO_DECLINE_GUILD_INVITES, 0x586F},
            {Opcode.CMSG_BATTLEFIELD_LIST, 0x32A4},
            {Opcode.CMSG_BATTLEFIELD_REQUEST_SCORE_DATA, 0x85A5},
            {Opcode.CMSG_BEGIN_TRADE, 0x3724},
            {Opcode.CMSG_BINDER_ACTIVATE, 0x58FB},
            {Opcode.CMSG_BUG, 0x1A77},
            {Opcode.CMSG_BUYBACK_ITEM, 0xDEE6},
            {Opcode.CMSG_BUY_BANK_SLOT, 0x487F},
            {Opcode.CMSG_BUY_ITEM, 0x1E5A},
            {Opcode.CMSG_CALENDAR_ADD_EVENT, 0x1CF3},
            // {Opcode.CMSG_CALENDAR_EVENT_INVITE, 0x1EDA}, // could be 0x4A76
            {Opcode.CMSG_CALENDAR_EVENT_MODERATOR_STATUS, 0xCCFA},
            {Opcode.CMSG_CALENDAR_EVENT_REMOVE_INVITE, 0xCCD2},
            {Opcode.CMSG_CALENDAR_EVENT_RSVP, 0x1EDA},
            {Opcode.CMSG_CALENDAR_EVENT_STATUS, 0x4E67},
            {Opcode.CMSG_CALENDAR_UPDATE_EVENT, 0x5CD2},
            {Opcode.CMSG_CANCEL_AUTO_REPEAT_SPELL, 0x5CEE},
            {Opcode.CMSG_CANCEL_CAST, 0x5A73},
            {Opcode.CMSG_CANCEL_CHANNELLING, 0xC8FE},
            {Opcode.CMSG_CANCEL_GROWTH_AURA, 0xDEF7},
            {Opcode.CMSG_CANCEL_MOUNT_AURA, 0xD8F3},
            {Opcode.CMSG_CANCEL_TEMP_ENCHANTMENT, 0x0ACE},
            {Opcode.CMSG_CANCEL_TRADE, 0x35A5},
            {Opcode.CMSG_CAST_SPELL, 0x5E4E},
            {Opcode.CMSG_CHANNEL_ANNOUNCEMENTS, 0x70D1},
            {Opcode.CMSG_CHANNEL_KICK, 0x3049},
            {Opcode.CMSG_CHANNEL_MODERATOR, 0x20D1},
            {Opcode.CMSG_CHANNEL_MUTE, 0x34C9},
            {Opcode.CMSG_CHANNEL_SET_OWNER, 0x7449},
            {Opcode.CMSG_CHANNEL_UNBAN, 0x6451},
            {Opcode.CMSG_CHANNEL_UNMODERATOR, 0x6051},
            {Opcode.CMSG_CHANNEL_UNMUTE, 0x74C9},
            {Opcode.CMSG_DECLINE_CHANNEL_INVITE, 0x4EFB},
            {Opcode.CMSG_DUEL_ACCEPTED, 0x9CCB},
            {Opcode.CMSG_DUEL_CANCELLED, 0x1E4F},
            {Opcode.CMSG_CHANNEL_BAN, 0x2041},
            {Opcode.CMSG_CHANNEL_INVITE, 0x7451},
            {Opcode.CMSG_CHAR_CREATE, 0x1AC6},
            {Opcode.CMSG_CHAR_CUSTOMIZE, 0xDECF},
            {Opcode.CMSG_CHAR_DELETE, 0x1ED3},
            {Opcode.CMSG_CHAR_ENUM, 0x4A8B},
            {Opcode.CMSG_CHAR_FACTION_CHANGE, 0xCCEE},
            {Opcode.CMSG_CHAR_RACE_CHANGE, 0xDC57},
            {Opcode.CMSG_CHAR_RENAME, 0x5E6F},
            {Opcode.CMSG_CLEAR_CHANNEL_WATCH, 0x9CC2},
            {Opcode.CMSG_COMMENTATOR_ENABLE, 0x1CF7},
            {Opcode.CMSG_COMMENTATOR_ENTER_INSTANCE, 0x8EF6},
            {Opcode.CMSG_COMMENTATOR_EXIT_INSTANCE, 0x4C7B},
            {Opcode.CMSG_COMMENTATOR_GET_MAP_INFO, 0xDEE7},
            {Opcode.CMSG_COMMENTATOR_GET_PLAYER_INFO, 0x9EF3},
            {Opcode.CMSG_COMMENTATOR_INSTANCE_COMMAND, 0x5CEB},
            {Opcode.CMSG_COMMENTATOR_SKIRMISH_QUEUE_COMMAND, 0x9C4E},
            {Opcode.CMSG_COMPLETE_CINEMATIC, 0x1A6F},
            {Opcode.CMSG_CONTACT_LIST, 0xCECF},
            {Opcode.CMSG_CORPSE_MAP_POSITION_QUERY, 0xDC7F},
            {Opcode.CMSG_CREATURE_QUERY, 0x5A7E},
            {Opcode.CMSG_DANCE_QUERY, 0x5C5E},
            {Opcode.CMSG_DEL_FRIEND, 0xC852},
            {Opcode.CMSG_DEL_IGNORE, 0x8ADA},
            {Opcode.CMSG_DEL_VOICE_IGNORE, 0x8C73},
            {Opcode.CMSG_DESTROYITEM, 0x4E7A},
            {Opcode.CMSG_EMOTE, 0x9843},
            {Opcode.CMSG_EQUIPMENT_SET_DELETE, 0x9CF2},
            {Opcode.CMSG_EQUIPMENT_SET_SAVE, 0x5E5F},
            {Opcode.CMSG_EQUIPMENT_SET_USE, 0x4853},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0xCEFF},
            {Opcode.CMSG_GAMEOBJ_REPORT_USE, 0x9A4A},
            {Opcode.CMSG_GAMEOBJ_USE, 0x1E77},
            {Opcode.CMSG_GET_MAIL_LIST, 0xB284},
            {Opcode.CMSG_GET_MIRRORIMAGE_DATA, 0xDAF3},
            {Opcode.CMSG_GMTICKET_DELETETICKET, 0x0C87F},
            {Opcode.CMSG_GMTICKET_GETTICKET, 0x0985F},
            {Opcode.CMSG_GMTICKET_SYSTEMSTATUS, 0x4A7A},
            {Opcode.CMSG_GMTICKET_UPDATETEXT, 0x8A7B},
            {Opcode.CMSG_GOSSIP_HELLO, 0xAD3},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x984E},
            {Opcode.CMSG_GRANT_LEVEL, 0x1CD6},
            {Opcode.CMSG_GROUP_ASSISTANT_LEADER, 0xC8CA},
            {Opcode.CMSG_GROUP_CHANGE_SUB_GROUP, 0x1AD2},
            {Opcode.CMSG_GROUP_RAID_CONVERT, 0xC85A},
            {Opcode.CMSG_GROUP_SET_LEADER, 0xCEC7},
            {Opcode.CMSG_GROUP_SWAP_SUB_GROUP, 0x5AD7},
            {Opcode.CMSG_GROUP_UNINVITE_GUID, 0xCE66},
            {Opcode.CMSG_GUILDFINDER_JOIN, 0x68C5},
            {Opcode.CMSG_GUILD_BANKER_ACTIVATE, 0x4E77},
            {Opcode.CMSG_GUILD_BANK_DEPOSIT_MONEY, 0x4847},
            {Opcode.CMSG_GUILD_BANK_QUERY_TAB, 0xDE46},
            {Opcode.CMSG_GUILD_BANK_SWAP_ITEMS, 0x85B},
            {Opcode.CMSG_GUILD_INFO, 0xCE76},
            {Opcode.CMSG_GUILD_INVITE, 0x8C67},
            {Opcode.CMSG_GUILD_LEADER, 0x28C4},
            {Opcode.CMSG_GUILD_QUERY, 0x8E57},
            {Opcode.CMSG_GUILD_RANK, 0x8D50},
            {Opcode.CMSG_GUILD_ROSTER, 0x9952},
            {Opcode.CMSG_GUILD_SET_NOTE, 0x9958},
            {Opcode.CMSG_HEARTH_AND_RESURRECT, 0xDC4E},
            {Opcode.CMSG_INSPECT, 0x9A7B},
            {Opcode.CMSG_INSTANCE_LOCK_WARNING_RESPONSE, 0x8CF7},
            {Opcode.CMSG_ITEM_REFUND, 0xCC3},
            {Opcode.CMSG_ITEM_REFUND_INFO, 0x1C7E},
            {Opcode.CMSG_ITEM_TEXT_QUERY, 0x4AEB},
            {Opcode.CMSG_JOIN_CHANNEL, 0x3441},
            {Opcode.CMSG_KEEP_ALIVE, 0xC87A},
            {Opcode.CMSG_LEARN_PREVIEW_TALENTS, 0xDEE3},
            {Opcode.CMSG_LEARN_PREVIEW_TALENTS_PET, 0x9AFB},
            {Opcode.CMSG_LEARN_TALENT, 0x98F3},
            {Opcode.CMSG_LEAVE_BATTLEFIELD, 0x1AE7},
            {Opcode.CMSG_LFG_LFR_JOIN, 0x8CFA},
            {Opcode.SMSG_LFG_PARTY_INFO, 0x5E47},
            {Opcode.CMSG_LFG_PARTY_LOCK_INFO_REQUEST, 0xC867},
            {Opcode.CMSG_LFG_SET_ROLES, 0x4843},
            {Opcode.CMSG_LFG_TELEPORT, 0x8C7A},
            {Opcode.SMSG_LFG_OFFER_CONTINUE, 0x8E7E},
            {Opcode.SMSG_LFG_ROLE_CHOSEN, 0x8C5A},
            {Opcode.SMSG_LFG_DISABLED, 0xCAEA},
            {Opcode.SMSG_LFG_JOIN_RESULT, 0xCCCB},
            {Opcode.SMSG_LFG_UPDATE_PARTY, 0xCCF6},
            {Opcode.SMSG_LFG_ROLE_CHECK_UPDATE, 0x5C6F},
            {Opcode.SMSG_LFG_TELEPORT_DENIED, 0x585F},
            {Opcode.SMSG_LFG_QUEUE_STATUS, 0x5AF6},
            {Opcode.SMSG_LFG_UPDATE_SEARCH, 0x1E53},
            {Opcode.SMSG_LFG_PROPOSAL_UPDATE, 0x485E},
            {Opcode.SMSG_LFG_BOOT_PLAYER, 0x4A5F},
            {Opcode.CMSG_LIST_INVENTORY, 0xDCFE},
            {Opcode.CMSG_LOAD_SCREEN, 0x0888},
            {Opcode.CMSG_LOGOUT_CANCEL, 0xA76},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x4C7A},
            {Opcode.CMSG_LOOT, 0x1E62},
            {Opcode.CMSG_LOOT_MONEY, 0x4A42},
            {Opcode.CMSG_LOOT_RELEASE, 0x4A6A},
            {Opcode.CMSG_MAIL_CREATE_TEXT_ITEM, 0x886E},
            {Opcode.CMSG_MAIL_DELETE, 0x4CCF},
            {Opcode.CMSG_MAIL_RETURN_TO_SENDER, 0x587E},
            {Opcode.CMSG_MAIL_TAKE_ITEM, 0xCC2},
            {Opcode.CMSG_MAIL_TAKE_MONEY, 0x4CD6},
            {Opcode.CMSG_MEETINGSTONE_INFO, 0xCA5B},
            {Opcode.CMSG_MESSAGECHAT_ADDON_BATTLEGROUND, 0x6059},
            {Opcode.CMSG_MESSAGECHAT_ADDON_GUILD, 0x24D9},
            {Opcode.CMSG_MESSAGECHAT_ADDON_PARTY, 0x6041},
            {Opcode.CMSG_MESSAGECHAT_ADDON_RAID, 0x3041},
            {Opcode.CMSG_MESSAGECHAT_ADDON_WHISPER, 0x20C1},
            {Opcode.CMSG_MESSAGECHAT_CHANNEL, 0x7459},
            {Opcode.CMSG_MESSAGECHAT_EMOTE, 0x6449},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x60C1},
            {Opcode.CMSG_MESSAGECHAT_PARTY, 0x24C9},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x2459},
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x70D9},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x70C1},
            {Opcode.CMSG_NAME_QUERY, 0x586A},
            {Opcode.CMSG_NEXT_CINEMATIC_CAMERA, 0x8E63},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x5C63},
            {Opcode.CMSG_OFFER_PETITION, 0xC8DE},
            {Opcode.CMSG_OPENING_CINEMATIC, 0xD8D2},
            {Opcode.CMSG_OPEN_ITEM, 0x88C7},
            {Opcode.CMSG_PAGE_TEXT_QUERY, 0x8A5F},
            {Opcode.CMSG_PETITION_BUY, 0x8E4E},
            {Opcode.CMSG_PETITION_QUERY, 0xCEF3},
            {Opcode.CMSG_PETITION_SHOW_SIGNATURES, 0x1E66},
            {Opcode.CMSG_PETITION_SIGN, 0x4A5E},
            {Opcode.CMSG_PET_ACTION, 0x1AEA},
            {Opcode.CMSG_PET_LEARN_TALENT, 0x48E6},
            {Opcode.CMSG_PET_NAME_QUERY, 0xDA76},
            {Opcode.CMSG_PING, 0x1008},
            {Opcode.CMSG_PLAYED_TIME, 0x5A56},
            {Opcode.CMSG_PLAYER_LOGIN, 0x0898},
            {Opcode.CMSG_PLAYER_LOGOUT, 0x1CEE},
            {Opcode.CMSG_PLAY_DANCE, 0x5857},
            {Opcode.CMSG_PUSHQUESTTOPARTY, 0xA47},
            {Opcode.CMSG_QUERY_QUESTS_COMPLETED, 0x98DF},
            {Opcode.CMSG_QUERY_TIME, 0x18FE},
            {Opcode.CMSG_QUESTGIVER_ACCEPT_QUEST, 0x0C63},
            {Opcode.CMSG_QUESTGIVER_CHOOSE_REWARD, 0x18F3},
            {Opcode.CMSG_QUESTGIVER_COMPLETE_QUEST, 0xCCE3},
            {Opcode.CMSG_QUESTGIVER_HELLO, 0xC86A},
            {Opcode.CMSG_QUESTGIVER_QUERY_QUEST, 0x8CE7},
            {Opcode.CMSG_QUESTGIVER_REQUEST_REWARD, 0xD8E7},
            {Opcode.CMSG_QUESTGIVER_STATUS_MULTIPLE_QUERY, 0xC8DB},
            {Opcode.CMSG_QUESTGIVER_STATUS_QUERY, 0x88C6},
            {Opcode.CMSG_QUESTLOG_REMOVE_QUEST, 0x8EFF},
            {Opcode.CMSG_QUEST_CONFIRM_ACCEPT, 0x8CD3},
            {Opcode.CMSG_QUEST_NPC_QUERY, 0x9ED6},
            {Opcode.CMSG_QUEST_POI_QUERY, 0x12A5},
            {Opcode.CMSG_QUEST_QUERY, 0xCE7F},
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x8A99},
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0xCCDB},
            {Opcode.CMSG_READ_ITEM, 0x184F},
            {Opcode.CMSG_REALM_SPLIT, 0xDC66},
            {Opcode.CMSG_RECLAIM_CORPSE, 0x88DB},
            {Opcode.CMSG_REDIRECTION_AUTH_PROOF, 0x1039},
            {Opcode.CMSG_REPAIR_ITEM, 0xCF3},
            {Opcode.CMSG_REPOP_REQUEST, 0x8872},
            {Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x8AF2},
            {Opcode.CMSG_REQUEST_PARTY_MEMBER_STATS, 0x987E},
            {Opcode.CMSG_REQUEST_PET_INFO, 0x9A47},
            {Opcode.CMSG_REQUEST_RAID_INFO, 0xECF},
            {Opcode.CMSG_REQUEST_VEHICLE_EXIT, 0xCC6},
            {Opcode.CMSG_REQUEST_VEHICLE_NEXT_SEAT, 0xCAD6},
            {Opcode.CMSG_REQUEST_VEHICLE_PREV_SEAT, 0x1AE2},
            {Opcode.CMSG_REQUEST_VEHICLE_SWITCH_SEAT, 0x9A46},
            {Opcode.CMSG_RESET_INSTANCES, 0x9EEA},
            {Opcode.CMSG_RETURN_TO_GRAVEYARD, 0x91A4},
            {Opcode.CMSG_SELF_RES, 0xCCFE},
            {Opcode.CMSG_SELL_ITEM, 0x5EE3},
            {Opcode.CMSG_SETSHEATHED, 0xCA5F},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0xDAC3},
            {Opcode.CMSG_SET_ACTIONBAR_TOGGLES, 0x584F},
            {Opcode.CMSG_SET_ALLOW_LOW_LEVEL_RAID1, 0xC863},
            {Opcode.CMSG_SET_ALLOW_LOW_LEVEL_RAID2, 0x4CE7},
            {Opcode.CMSG_SET_CONTACT_NOTES, 0x1AF3},
            {Opcode.CMSG_SET_PLAYER_DECLINED_NAMES, 0xC847},
            {Opcode.CMSG_SET_PRIMARY_TALENT_TREE, 0x185E},
            {Opcode.CMSG_SET_SAVED_INSTANCE_EXTEND, 0x8E62},
            {Opcode.CMSG_SET_SELECTION, 0x4C4E},
            {Opcode.CMSG_SET_TAXI_BENCHMARK_MODE, 0x1EFF},
            {Opcode.CMSG_SET_TITLE, 0xCE63},
            {Opcode.CMSG_SHOWING_CLOAK, 0x8AE3},
            {Opcode.CMSG_SHOWING_HELM, 0xCEFA},
            {Opcode.CMSG_SPELLCLICK, 0xC8F2},
            {Opcode.CMSG_SPIRIT_HEALER_ACTIVATE, 0x5AEB},
            {Opcode.CMSG_SPLIT_ITEM, 0xDCFA},
            {Opcode.CMSG_STANDSTATECHANGE, 0x9EC6},
            {Opcode.CMSG_SUMMON_RESPONSE, 0xD84E},
            {Opcode.CMSG_SUSPEND_TOKEN, 0x1009},
            {Opcode.CMSG_SWAP_INV_ITEM, 0x5CE7},
            {Opcode.CMSG_SWAP_ITEM, 0xDED6},
            {Opcode.CMSG_TAXINODE_STATUS_QUERY, 0x98E3},
            {Opcode.CMSG_TELEPORT_TO_UNIT, 0x8C72},
            {Opcode.CMSG_TEXT_EMOTE, 0x08D3},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x07A5},
            {Opcode.CMSG_TOGGLE_PVP, 0x8ECA},
            {Opcode.CMSG_TRAINER_BUY_SPELL, 0xAF7},
            {Opcode.CMSG_TRAINER_LIST, 0xCC7F},
            {Opcode.CMSG_TURN_IN_PETITION, 0x9C67},
            {Opcode.CMSG_UNLEARN_SKILL, 0xAC3},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x4AFE},
            {Opcode.CMSG_UPDATE_PROJECTILE_POSITION, 0xEDB},
            {Opcode.CMSG_USE_ITEM, 0xD8EA},
            {Opcode.CMSG_WARDEN_DATA, 0x5847},
            {Opcode.CMSG_WHO, 0x9AD7},
            {Opcode.CMSG_WHOIS, 0xCCE6},
            {Opcode.CMSG_WORLD_STATE_UI_TIMER_UPDATE, 0x58F6},
            {Opcode.CMSG_ZONEUPDATE, 0x4AE2},
            {Opcode.MSG_AUCTION_HELLO, 0xCC7A},
            {Opcode.MSG_CHANNEL_START, 0xDCC2},
            {Opcode.MSG_CHANNEL_UPDATE, 0xCC5E},
            {Opcode.MSG_CORPSE_QUERY, 0xC876},
            {Opcode.MSG_GUILD_BANK_MONEY_WITHDRAWN, 0xDE77},
            {Opcode.MSG_GUILD_EVENT_LOG_QUERY, 0xCEDA},
            {Opcode.MSG_GUILD_PERMISSIONS, 0xDC73},
            {Opcode.MSG_INSPECT_ARENA_TEAMS, 0xDA4F},
            {Opcode.MSG_LIST_STABLED_PETS, 0x88CA},
            {Opcode.MSG_MOVE_HEARTBEAT, 0xB024},
            {Opcode.MSG_MOVE_JUMP, 0x9225},
            {Opcode.MSG_MOVE_KNOCK_BACK, 0x60FE}, // Not sure
            {Opcode.MSG_MOVE_SET_FACING, 0x02a4},
            {Opcode.MSG_MOVE_SET_PITCH, 0xA7A5},
            {Opcode.MSG_MOVE_SET_RUN_MODE, 0x21A4},
            {Opcode.MSG_MOVE_SET_WALK_MODE, 0x24A4},
            {Opcode.MSG_MOVE_START_ASCEND, 0x0624},
            {Opcode.MSG_MOVE_START_BACKWARD, 0x10A5},
            {Opcode.MSG_MOVE_START_DESCEND, 0x2624},
            {Opcode.MSG_MOVE_START_FORWARD, 0xA0A4},
            {Opcode.MSG_MOVE_START_PITCH_DOWN, 0x2025},
            {Opcode.MSG_MOVE_START_PITCH_UP, 0x9524},
            {Opcode.MSG_MOVE_START_STRAFE_LEFT, 0xA024},
            {Opcode.MSG_MOVE_START_STRAFE_RIGHT, 0x9125},
            {Opcode.MSG_MOVE_START_SWIM, 0x85A4},
            {Opcode.MSG_MOVE_START_TURN_LEFT, 0x01A5},
            {Opcode.MSG_MOVE_START_TURN_RIGHT, 0xB6A4},
            {Opcode.MSG_MOVE_STOP, 0xA3A4},
            {Opcode.MSG_MOVE_STOP_ASCEND, 0x1125},
            {Opcode.MSG_MOVE_STOP_PITCH, 0x8425},
            {Opcode.MSG_MOVE_STOP_STRAFE, 0x0125},
            {Opcode.MSG_MOVE_STOP_SWIM, 0xB424},
            {Opcode.MSG_MOVE_STOP_TURN, 0x90A4},
            {Opcode.MSG_MOVE_SET_RUN_SPEED, 0xE24E},
            {Opcode.SMSG_SPLINE_SET_RUN_SPEED, 0xB2CE},
            {Opcode.MSG_PETITION_DECLINE, 0x98E7},
            {Opcode.MSG_PETITION_RENAME, 0x4857},
            {Opcode.MSG_QUERY_NEXT_MAIL_TIME, 0xCEE6},
            {Opcode.MSG_QUEST_PUSH_RESULT, 0x1863},
            {Opcode.MSG_RAID_READY_CHECK, 0x584E},
            {Opcode.MSG_RANDOM_ROLL, 0x4C57},
            {Opcode.MSG_SAVE_GUILD_EMBLEM, 0x4EE3},
            {Opcode.MSG_SET_DUNGEON_DIFFICULTY, 0xC4F},
            {Opcode.MSG_SET_RAID_DIFFICULTY, 0x1A5A},
            {Opcode.MSG_TABARDVENDOR_ACTIVATE, 0x98EB},
            {Opcode.MSG_TALENT_WIPE_CONFIRM, 0x4C52}, // Not confirmed. ERR_NOT_ENOUGH_MONEY is sent
            {Opcode.MSG_VERIFY_CONNECTIVITY, 0x4F57},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x5EE2},
            {Opcode.SMSG_ACHIEVEMENT_DELETED, 0x9ED2},
            {Opcode.SMSG_ACHIEVEMENT_EARNED, 0x484E},
            {Opcode.SMSG_ACTION_BUTTONS, 0x8A6B},
            {Opcode.SMSG_ACTIVATETAXIREPLY, 0x8E4F},
            {Opcode.SMSG_ADDON_INFO, 0x9863},
            {Opcode.SMSG_AI_REACTION, 0xCEC2},
            {Opcode.SMSG_AREA_TRIGGER_MESSAGE, 0xCC42},
            {Opcode.SMSG_ARENA_ERROR, 0x8C7},
            {Opcode.SMSG_ARENA_OPPONENT_UPDATE, 0xAD6},
            {Opcode.SMSG_ARENA_TEAM_CHANGE_FAILED_QUEUED, 0x4A4E},
            {Opcode.SMSG_ARENA_TEAM_COMMAND_RESULT, 0x605C},
            {Opcode.SMSG_ARENA_TEAM_EVENT, 0x5CDA},
            {Opcode.SMSG_ARENA_TEAM_INVITE, 0x5EDB},
            {Opcode.SMSG_ARENA_TEAM_QUERY_RESPONSE, 0x8CCE},
            {Opcode.SMSG_ARENA_TEAM_ROSTER, 0xCE7A},
            {Opcode.SMSG_ARENA_TEAM_STATS, 0xDEF2},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x0E6A},
            {Opcode.SMSG_ATTACKSTART, 0xCA4A},
            {Opcode.SMSG_ATTACKSTOP, 0xCED7},
            {Opcode.SMSG_AUCTION_BIDDER_LIST_RESULT, 0x88E3},
            {Opcode.SMSG_AUCTION_BIDDER_NOTIFICATION, 0xC85B},
            {Opcode.SMSG_AUCTION_COMMAND_RESULT, 0xCCCE},
            {Opcode.SMSG_AUCTION_LIST_PENDING_SALES, 0x8EC7},
            {Opcode.SMSG_AUCTION_LIST_RESULT, 0xDEDE},
            {Opcode.SMSG_AUCTION_OWNER_LIST_RESULT, 0x4EDA},
            {Opcode.SMSG_AUCTION_OWNER_NOTIFICATION, 0xCA6A},
            {Opcode.SMSG_AUCTION_REMOVED_NOTIFICATION, 0x4CFB},
            {Opcode.SMSG_AURA_UPDATE, 0x4C66},
            {Opcode.SMSG_AURA_UPDATE_ALL, 0x18EE},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x1181},
            {Opcode.SMSG_AUTH_RESPONSE, 0x8867},
            {Opcode.SMSG_AVAILABLE_VOICE_CHANNEL, 0x9C7B},
            {Opcode.SMSG_BARBER_SHOP_RESULT, 0x9847},
            {Opcode.SMSG_BATTLEFIELD_LIST, 0xB64E},
            {Opcode.SMSG_BATTLEFIELD_MGR_EJECTED, 0x32EC},
            {Opcode.SMSG_BATTLEFIELD_MGR_EJECT_PENDING, 0x724C},
            {Opcode.SMSG_BATTLEFIELD_MGR_ENTERED, 0x66DC},
            {Opcode.SMSG_BATTLEFIELD_MGR_ENTRY_INVITE, 0x70DE},
            {Opcode.SMSG_BATTLEFIELD_MGR_QUEUE_INVITE, 0x644E},
            {Opcode.SMSG_BATTLEFIELD_MGR_QUEUE_REQUEST_RESPONSE, 0x326E},
            {Opcode.SMSG_BATTLEFIELD_MGR_STATE_CHANGE, 0x32EE},
            {Opcode.SMSG_BATTLEFIELD_STATUS1, 0x70EE},
            {Opcode.SMSG_BATTLEFIELD_STATUS2, 0x20DC},
            {Opcode.SMSG_BATTLEFIELD_STATUS3, 0x36DE},
            {Opcode.SMSG_BATTLEFIELD_STATUS4, 0x626E},
            {Opcode.SMSG_BINDER_CONFIRM, 0x0ADA},
            {Opcode.SMSG_BINDZONEREPLY, 0x1A42},
            {Opcode.SMSG_BREAK_TARGET, 0x0E7E},
            {Opcode.SMSG_BUY_FAILED, 0x4A7F},
            {Opcode.SMSG_BUY_ITEM, 0xCA67},
            {Opcode.SMSG_CALENDAR_COMMAND_RESULT, 0x9A4E},
            {Opcode.SMSG_CALENDAR_SEND_CALENDAR, 0x08FB},
            {Opcode.SMSG_CAMERA_SHAKE, 0x5CFB},
            {Opcode.SMSG_CANCEL_AUTO_REPEAT, 0x5ACB},
            {Opcode.SMSG_CAST_FAILED, 0x1AEB},
            {Opcode.SMSG_CHANNEL_LIST, 0x9C47},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x9C7F},
            {Opcode.SMSG_CHANNEL_MEMBER_COUNT, 0x5EEA},
            {Opcode.SMSG_CHARACTER_LOGIN_FAILED, 0x4AE6},
            {Opcode.SMSG_CHAR_CREATE, 0x4C5B},
            {Opcode.SMSG_CHAR_CUSTOMIZE, 0xAE3},
            {Opcode.SMSG_CHAR_DELETE, 0x48CE},
            {Opcode.SMSG_CHAR_ENUM, 0xA05C},
            {Opcode.SMSG_CHAR_FACTION_CHANGE, 0x885A},
            {Opcode.SMSG_CHAR_RENAME, 0x5EF6},
            {Opcode.SMSG_CHAT_PLAYER_AMBIGUOUS, 0xDE7F},
            {Opcode.SMSG_CHAT_PLAYER_NOT_FOUND, 0x4E6F},
            {Opcode.SMSG_CHAT_RESTRICTED, 0x4863},
            {Opcode.SMSG_CHAT_WRONG_FACTION, 0xE66},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x88F2},
            {Opcode.SMSG_CLIENT_CONTROL_UPDATE, 0x08CB},
            {Opcode.SMSG_COMBAT_LOG_MULTIPLE, 0x5C56},
            {Opcode.SMSG_COMPRESSED_CHAR_ENUM, 0x380A},
            {Opcode.SMSG_COMPRESSED_GUILD_ROSTER, 0x5A29},
            {Opcode.SMSG_COMPRESSED_MOVES, 0x00862},
            {Opcode.SMSG_COMPRESSED_UPDATE_OBJECT, 0x1CC3},
            {Opcode.SMSG_CONTACT_LIST, 0x0A6B},
            {Opcode.SMSG_CORPSE_NOT_IN_INSTANCE, 0xCACB},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0xCD46},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0xD847},
            {Opcode.SMSG_CRITERIA_DELETED, 0x1A5B},
            {Opcode.SMSG_CRITERIA_UPDATE, 0xD87F},
            {Opcode.SMSG_CROSSED_INEBRIATION_THRESHOLD, 0x9CD7},
            {Opcode.SMSG_DAMAGE_CALC_LOG, 0x5C47},
            {Opcode.SMSG_DANCE_QUERY_RESPONSE, 0x9E42},
            {Opcode.SMSG_DB_REPLY, 0x76EC},
            {Opcode.SMSG_DEFENSE_MESSAGE, 0x09EC3},
            {Opcode.SMSG_DESTROY_OBJECT, 0x486B},
            {Opcode.SMSG_DISMOUNT, 0xCEE7},
            {Opcode.SMSG_DUEL_COMPLETE, 0x5846},
            {Opcode.SMSG_DUEL_COUNTDOWN, 0x1A5F},
            {Opcode.SMSG_DUEL_REQUESTED, 0x1EC6},
            {Opcode.SMSG_DUEL_WINNER, 0xDA52},
            {Opcode.SMSG_ECHO_PARTY_SQUELCH, 0x5ED7},
            {Opcode.SMSG_EMOTE, 0x0C67},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x18DF},
            {Opcode.SMSG_EXPECTED_SPAM_RECORDS, 0x48E7},
            {Opcode.SMSG_EXPLORATION_EXPERIENCE, 0x0EE7},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x70CE},
            {Opcode.SMSG_FISH_ESCAPED, 0x9C66},
            {Opcode.SMSG_FISH_NOT_HOOKED, 0x18C3},
            {Opcode.SMSG_FLIGHT_SPLINE_SYNC, 0x1C63},
            {Opcode.SMSG_FORCE_SEND_QUEUED_PACKETS, 0x1380},
            {Opcode.SMSG_FRIEND_STATUS, 0xD852},
            {Opcode.SMSG_GAMEOBJECT_DESPAWN_ANIM, 0x0A5E},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0xCCF7},
            {Opcode.SMSG_GAMESPEED_SET, 0x5ACA},
            {Opcode.SMSG_GAMETIME_SET, 0x9C4A},
            {Opcode.SMSG_GAMETIME_UPDATE, 0x18E3},
            {Opcode.SMSG_GMTICKET_SYSTEMSTATUS, 0x9C7E},
            {Opcode.SMSG_GM_MESSAGECHAT, 0x8E5E}, // Not confirmed
            {Opcode.SMSG_GODMODE, 0xDEEE},
            {Opcode.SMSG_GOSSIP_COMPLETE, 0xDE7B},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0xCCEB},
            {Opcode.SMSG_GOSSIP_POI, 0x1866},
            {Opcode.SMSG_GROUP_CANCEL, 0xED6},
            {Opcode.SMSG_GROUP_LIST, 0x5C7E},
            {Opcode.SMSG_GROUP_SET_LEADER, 0xCCF2},
            {Opcode.SMSG_GUILDFINDER_SEARCH_RESULT, 0xE0CE},
            {Opcode.SMSG_GUILD_BANK_LIST, 0x5EFB},
            {Opcode.SMSG_GUILD_COMMAND_RESULT, 56023},
            {Opcode.SMSG_GUILD_DECLINE, 0x1E5B},
            {Opcode.SMSG_GUILD_EVENT, 0x8AC2},
            {Opcode.SMSG_GUILD_INFO, 0x5876},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0xCA66},
            {Opcode.SMSG_GUILD_RANK, 0xA6EC},
            {Opcode.SMSG_GUILD_ROSTER, 0x664C},
            {Opcode.SMSG_GUILD_SET_NOTE, 0xB6CE},
            {Opcode.SMSG_HIGHEST_THREAT_UPDATE, 0x5E7B},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0xCC6F},
            {Opcode.SMSG_INITIAL_SPELLS, 0x88FE},
            {Opcode.SMSG_INIT_CURRENCY, 0x227E},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x9EDA},
            {Opcode.SMSG_INSPECT, 0xE46},
            {Opcode.SMSG_INSPECT_TALENT, 0x48EF},
            {Opcode.SMSG_INSTANCE_RESET, 0x0DAC2},
            {Opcode.SMSG_INSTANCE_RESET_FAILED, 0xCEFE},
            {Opcode.SMSG_INSTANCE_SAVE_CREATED, 0xCE56},
            {Opcode.SMSG_INVALIDATE_DANCE, 0x1EEF},
            {Opcode.SMSG_INVALIDATE_PLAYER, 0x5C5F},
            {Opcode.SMSG_INVALID_PROMOTION_CODE, 0xD8FE},
            {Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0xDCE6},
            {Opcode.SMSG_ITEM_PUSH_RESULT, 0x8EFB},
            {Opcode.SMSG_ITEM_REFUND_INFO_RESPONSE, 0x304E},
            {Opcode.SMSG_ITEM_REFUND_RESULT, 0x60DC},
            {Opcode.SMSG_ITEM_TEXT_QUERY_RESPONSE, 0x984A},
            {Opcode.SMSG_ITEM_TIME_UPDATE, 0x8AEB},
            {Opcode.SMSG_KICK_REASON, 0x8A67},
            {Opcode.SMSG_LEARNED_DANCE_MOVES, 0xE52},
            {Opcode.SMSG_LEARNED_SPELL, 0x88D3},
            {Opcode.SMSG_LEVELUP_INFO, 0x9A73},
            {Opcode.SMSG_LFG_PLAYER_INFO, 0xC85F},
            {Opcode.SMSG_LFG_UPDATE_LIST, 0x0EFB},
            {Opcode.SMSG_LIST_INVENTORY, 0x264C},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x05ECA},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0xC86E},
            {Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x0D8EF},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0xCC6B},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x886A},
            {Opcode.SMSG_LOG_XPGAIN, 0x4E7E},
            {Opcode.SMSG_LOOT_ALL_PASSED, 0x1C7A},
            {Opcode.SMSG_LOOT_CLEAR_MONEY, 0x586E},
            {Opcode.SMSG_LOOT_ITEM_NOTIFY, 0xD8E3},
            {Opcode.SMSG_LOOT_LIST, 0x8C5B},
            {Opcode.SMSG_LOOT_MASTER_LIST, 0xDE4E},
            {Opcode.SMSG_LOOT_MONEY_NOTIFY, 0x0EF3},
            {Opcode.SMSG_LOOT_RELEASE_RESPONSE, 0x88FF},
            {Opcode.SMSG_LOOT_REMOVED, 0x8E6B},
            {Opcode.SMSG_LOOT_RESPONSE, 0x0842},
            {Opcode.SMSG_LOOT_ROLL, 0x4C4F},
            {Opcode.SMSG_LOOT_ROLL_WON, 0x5E4B},
            {Opcode.SMSG_LOOT_SLOT_CHANGED, 0xDCDA},
            {Opcode.SMSG_LOOT_START_ROLL, 0xC8C2},
            {Opcode.SMSG_MAIL_LIST_RESULT, 0x5CD7},
            {Opcode.SMSG_MESSAGECHAT, 0x5E52},
            {Opcode.SMSG_NEW_WORLD, 0x647E},
            {Opcode.SMSG_MIRRORIMAGE_DATA, 0x8AFB},
            {Opcode.SMSG_MONSTER_MOVE, 0x4C53},
            {Opcode.SMSG_MONSTER_MOVE_TRANSPORT, 0x88FB},
            {Opcode.SMSG_MOTD, 0xCA4B},
            {Opcode.SMSG_MOUNTSPECIAL_ANIM, 0x09E77},
            {Opcode.SMSG_MULTIPLE_PACKETS, 0xDCEA},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x9CE6},
            {Opcode.SMSG_NEW_TAXI_PATH, 0xC8FF}, // Might be 0x98CF
            {Opcode.SMSG_NOTIFICATION, 0x1A56},
            {Opcode.SMSG_NOTIFY_DANCE, 0xCE62},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x4C72},
            {Opcode.SMSG_OFFER_PETITION_ERROR, 0x1E7F},
            {Opcode.SMSG_OVERRIDE_LIGHT, 0xCC56},
            {Opcode.SMSG_PAGE_TEXT_QUERY_RESPONSE, 0x18D2},
            {Opcode.SMSG_PARTYKILLLOG, 0xCCC2},
            {Opcode.SMSG_PARTY_MEMBER_STATS, 0xDC5A},
            {Opcode.SMSG_PARTY_MEMBER_STATS_FULL, 0x0EDF},
            {Opcode.SMSG_PETITION_QUERY_RESPONSE, 0xCAEE},
            {Opcode.SMSG_PETITION_SHOWLIST, 0x8ED7},
            {Opcode.SMSG_PETITION_SHOW_SIGNATURES, 0x4E4A},
            {Opcode.SMSG_PETITION_SIGN_RESULTS, 0x5EE6},
            {Opcode.SMSG_PET_ACTION_FEEDBACK, 0x4E5A},
            {Opcode.SMSG_PET_ACTION_SOUND, 0x0CC7},
            {Opcode.SMSG_PET_DISMISS_SOUND, 0x9A56},
            {Opcode.SMSG_PET_GUIDS, 0x5E6B},
            {Opcode.SMSG_PET_LEARNED_SPELL, 0xDC5E},
            {Opcode.SMSG_PET_MODE, 0x058DE},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0xDCD3},
            {Opcode.SMSG_PET_REMOVED_SPELL, 0x18F6}, // Should actually be called UNLEARNED_SPELL
            {Opcode.SMSG_PET_SPELLS, 0x5A43},
            {Opcode.SMSG_PET_UPDATE_COMBO_POINTS, 0x1A47},
            {Opcode.SMSG_PLAYED_TIME, 0x187F},
            {Opcode.SMSG_PLAYERBINDERROR, 0x5A4F},
            {Opcode.SMSG_PLAYERBOUND, 0xCC46},
            {Opcode.SMSG_PLAYER_DIFFICULTY_CHANGE, 0xD846},
            {Opcode.SMSG_PLAYER_MOVE, 0xF66C},
            {Opcode.SMSG_PLAYER_SKINNED, 0xDA63},
            {Opcode.SMSG_PLAYER_VEHICLE_DATA, 0x186E},
            {Opcode.SMSG_PLAY_DANCE, 0x8CFE},
            {Opcode.SMSG_PLAY_OBJECT_SOUND, 0xCC57},
            {Opcode.SMSG_PLAY_SOUND, 0x4ACF},
            {Opcode.SMSG_PLAY_TIME_WARNING, 0xD857},
            {Opcode.SMSG_PONG, 0x0380},
            {Opcode.SMSG_POWER_UPDATE, 0x487E},
            {Opcode.SMSG_PRE_RESURRECT, 0x1CFB},
            {Opcode.SMSG_PROPOSE_LEVEL_GRANT, 0x0C42},
            {Opcode.SMSG_PVP_CREDIT, 0x9EF2},
            {Opcode.SMSG_QUERY_TIME_RESPONSE, 0xD85A},
            {Opcode.SMSG_QUESTGIVER_QUEST_COMPLETE, 0x24EE},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0xCE5F},
            {Opcode.SMSG_QUESTGIVER_QUEST_FAILED, 0xD8FF},
            {Opcode.SMSG_QUESTGIVER_QUEST_LIST, 0xDEF6},
            {Opcode.SMSG_QUESTGIVER_REQUEST_ITEMS, 0x9CEE},
            {Opcode.SMSG_QUESTGIVER_STATUS, 0xC846},
            {Opcode.SMSG_QUESTGIVER_STATUS_MULTIPLE, 0xDCFF},
            {Opcode.SMSG_QUESTLOG_FULL, 0x4EDE},
            {Opcode.SMSG_QUESTUPDATE_ADD_ITEM, 0x9CCF},
            {Opcode.SMSG_QUESTUPDATE_COMPLETE, 0x9CD6},
            {Opcode.SMSG_QUESTUPDATE_FAILED, 0x9EF6},
            {Opcode.SMSG_QUEST_CONFIRM_ACCEPT, 0x184B},
            {Opcode.SMSG_QUEST_NPC_QUERY_RESPONSE, 0xF67C},
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x8CC3},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x9E56},
            {Opcode.SMSG_RAID_INSTANCE_INFO, 0x4ACA},
            {Opcode.SMSG_RAID_INSTANCE_MESSAGE, 0x0D862},
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0xF0DC},
            {Opcode.SMSG_READ_ITEM_FAILED, 0x0C5B},
            {Opcode.SMSG_READ_ITEM_OK, 0x9ECE},
            {Opcode.SMSG_REALM_SPLIT, 0x1AF2},
            {Opcode.SMSG_REAL_GROUP_UPDATE, 0x4C56},
            {Opcode.SMSG_RECEIVED_MAIL, 0xDEE2},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x0180},
            {Opcode.SMSG_REFER_A_FRIEND_FAILURE, 0x4867},
            {Opcode.SMSG_REMOVED_SPELL, 0x98FE},
            {Opcode.SMSG_RWHOIS, 0xCCE2},
            {Opcode.SMSG_SELL_ITEM, 0x9CD3},
            {Opcode.SMSG_SEND_MAIL_RESULT, 0x8CC2},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0xCED2},
            {Opcode.SMSG_SERVERTIME, 0x01CD7},
            {Opcode.SMSG_SERVER_FIRST_ACHIEVEMENT, 0x0CDF},
            {Opcode.SMSG_SERVER_MESSAGE, 0xC873},
            {Opcode.SMSG_SET_FACTION_ATWAR, 0x1E47},
            {Opcode.SMSG_SET_FACTION_STANDING, 0x1AE3},
            {Opcode.SMSG_SET_FACTION_VISIBLE, 0x4CEB},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x4EF2},
            {Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x485B},
            {Opcode.SMSG_SET_FORCED_REACTIONS, 0xD8C3},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x204C},
            {Opcode.SMSG_SET_PLAYER_DECLINED_NAMES_RESULT, 0xE67},
            {Opcode.SMSG_SET_PROFICIENCY, 0x9C5F},
            {Opcode.SMSG_SPELLDAMAGESHIELD, 0x8AFE},
            {Opcode.SMSG_SPELLENERGIZELOG, 0xD8FB},
            {Opcode.SMSG_SPELLHEALLOG, 0xDE4A},
            {Opcode.SMSG_SPELLINSTAKILLLOG, 0x8ED2},
            {Opcode.SMSG_SPELLLOGEXECUTE, 0x8AD7},
            {Opcode.SMSG_SPELLLOGMISS, 0x1CFF},
            {Opcode.SMSG_SPELLNONMELEEDAMAGELOG, 0x5CCF},
            {Opcode.SMSG_SPELLORDAMAGE_IMMUNE, 0x48FA},
            {Opcode.SMSG_SPELL_COOLDOWN, 0x88D6},
            {Opcode.SMSG_SPELL_DELAYED, 0x1AD3},
            {Opcode.SMSG_SPELL_FAILED_OTHER, 0xCE4A},
            {Opcode.SMSG_SPELL_FAILURE, 0x9A66},
            {Opcode.SMSG_SPELL_GO, 0x0A53},
            {Opcode.SMSG_SPELL_START, 0xCE43},
            {Opcode.SMSG_STABLE_RESULT, 0xA5B},
            {Opcode.SMSG_STANDSTATE_UPDATE, 0x4E52},
            {Opcode.SMSG_STOP_DANCE, 0x8E5F},
            {Opcode.SMSG_SUMMON_REQUEST, 0x9A52},
            {Opcode.SMSG_SUPERCEDED_SPELL, 0xDE53},
            {Opcode.SMSG_SUSPEND_TOKEN_RESPONSE, 0xE2EE},
            {Opcode.SMSG_TALENTS_INFO, 0x5EC6},
            {Opcode.SMSG_TALENTS_INVOLUNTARILY_RESET, 0x1C7B},
            {Opcode.SMSG_TAXINODE_STATUS, 0x8CFB}, // {Opcode.SMSG_SHOWTAXINODES, 0x8CFB},
            {Opcode.SMSG_TEXT_EMOTE, 0x9E5A},
            {Opcode.SMSG_THREAT_CLEAR, 0x9E4A},
            {Opcode.SMSG_THREAT_REMOVE, 0x8A7E},
            {Opcode.SMSG_THREAT_UPDATE, 0x0CE3},
            {Opcode.SMSG_TIME_SYNC_REQ, 0xE46E},
            {Opcode.SMSG_TITLE_EARNED, 0x1AFA},
            {Opcode.SMSG_TOGGLE_XP_GAIN, 0x8A5B},
            {Opcode.SMSG_TRAINER_BUY_SUCCEEDED, 0xDCDE},
            {Opcode.SMSG_TRAINER_LIST, 0xC84E},
            {Opcode.SMSG_TRANSFER_ABORTED, 0x0CF7},
            {Opcode.SMSG_TRANSFER_PENDING, 0xCA6E},
            {Opcode.SMSG_TRIGGER_CINEMATIC, 0xCE5B},
            {Opcode.SMSG_TURN_IN_PETITION_RESULTS, 0x08DB},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x1A46},
            {Opcode.SMSG_UNIT_SPELLCAST_START, 0x8C63},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA, 0x4A73},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA_COMPLETE, 0x5E53},
            {Opcode.SMSG_UPDATE_COMBO_POINTS, 0x9AF6},
            {Opcode.SMSG_UPDATE_INSTANCE_OWNERSHIP, 0xCA73},
            {Opcode.SMSG_UPDATE_ITEM_ENCHANTMENTS, 0xCA43},
            {Opcode.SMSG_UPDATE_LAST_INSTANCE, 0x58FE},
            {Opcode.SMSG_UPDATE_OBJECT, 0x1EE7},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x08E2},
            {Opcode.SMSG_USERLIST_ADD, 0x4CEE},
            {Opcode.SMSG_USERLIST_REMOVE, 0x9A6B},
            {Opcode.SMSG_USERLIST_UPDATE, 0x4A4B},
            {Opcode.SMSG_VOICE_CHAT_STATUS, 0x9ADF},
            {Opcode.SMSG_VOICE_PARENTAL_CONTROLS, 0x5ADE},
            {Opcode.SMSG_VOICE_SESSION_LEAVE, 0xCE72},
            {Opcode.SMSG_VOICE_SESSION_ROSTER_UPDATE, 0x8AC7},
            {Opcode.SMSG_VOICE_SET_TALKER_MUTED, 0x8873},
            {Opcode.SMSG_WARDEN_DATA, 0x484F},
            {Opcode.SMSG_WEATHER, 0x4ECE},
            {Opcode.SMSG_WHO, 0x4C7F},
            {Opcode.SMSG_WHOIS, 0x9CFF},
            {Opcode.SMSG_WORLD_STATE_UI_TIMER_UPDATE, 0xDE5E},
            {Opcode.SMSG_ZONE_UNDER_ATTACK, 0x08CF},

            // Unsure
            /*
                {Opcode.SMSG_COMPRESSED_UNK, 0x1381},
                {Opcode.SMSG_COMPRESSED_UNK, 0x5C3B},
            */

            // Tests
            {Opcode.TEST_422_41036, 0xA04C},
            {Opcode.TEST_422_24649, 24649},
            {Opcode.TEST_422_265C, 0x265C},
            {Opcode.TEST_422_26948, 26948},
            {Opcode.TEST_422_9838, 9838},
            {Opcode.TEST_422_51447, 0xC8F7},

            // CMSG Handlers
            // 4120 - sub_65D6A0 - CMSG_LFG_LFR_JOIN ?
            // 4152 - sub_65D540 - CMSG_LFG_LFR_LEAVE ?
            // 1061 - sub_664260
            // 35467 - sub_660390
            // 33476 - sub_B0C690 (4.3: 10764 - sub_69AFC0) (guid bitstreaming)
        };
    }
}
