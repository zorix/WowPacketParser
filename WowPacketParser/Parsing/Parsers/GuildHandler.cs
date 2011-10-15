using System;
using WowPacketParser.Enums;
using WowPacketParser.Misc;

namespace WowPacketParser.Parsing.Parsers
{
    public static class GuildHandler
    {
        private static void ReadEmblemInfo(Packet packet)
        {
            packet.ReadInt32("Emblem Style");
            packet.ReadInt32("Emblem Color");
            packet.ReadInt32("Emblem Border Style");
            packet.ReadInt32("Emblem Border Color");
            packet.ReadInt32("Emblem Background Color");
        }

        [Parser(Opcode.CMSG_GUILD_ROSTER)]
        [Parser(Opcode.CMSG_GUILD_ACCEPT)]
        [Parser(Opcode.CMSG_GUILD_DECLINE)]
        [Parser(Opcode.CMSG_GUILD_INFO)]
        [Parser(Opcode.CMSG_GUILD_LEAVE)]
        [Parser(Opcode.CMSG_GUILD_DISBAND)]
        [Parser(Opcode.CMSG_GUILD_DEL_RANK)]
        public static void HandleGuild(Packet packet)
        {
            // Moved here to have all Guild related opcodes together
        }

        [Parser(Opcode.SMSG_GUILD_ROSTER)]
        public static void HandleGuildRosterPacket(Packet packet)
        {
            var size = packet.ReadUInt32("Number Of Members");
            packet.ReadCString("MOTD");
            packet.ReadCString("Info");

            var numFields = packet.ReadInt32("Number Of Ranks");
            for (var i = 0; i < numFields; i++)
            {
                packet.ReadEnum<GuildRankRightsFlag>("[" + i + "] Rights", TypeCode.UInt32);
                packet.ReadInt32("[" + i + "] Money Per Day");

                for (var j = 0; j < 6; j++)
                {
                    packet.ReadEnum<GuildBankRightsFlag>("[" + i + "][" + j + "] Tab Rights", TypeCode.UInt32);
                    packet.ReadInt32("[" + i + "][" + j + "] Tab Slots");
                }
            }

            for (var i = 0; i < size; i++)
            {
                packet.ReadGuid("[" + i + "] GUID");
                var online = packet.ReadBoolean("[" + i + "] Online");

                packet.ReadCString("[" + i + "] Name");
                packet.ReadUInt32("[" + i + "] Rank Id");
                packet.ReadByte("[" + i + "] Level");
                packet.ReadByte("[" + i + "] Class");
                packet.ReadByte("[" + i + "] Unk");
                packet.ReadUInt32("[" + i + "] Zone Id");

                if (!online)
                    packet.ReadUInt32("[" + i + "] Last Online");

                packet.ReadCString("[" + i + "] Public Note");
                packet.ReadCString("[" + i + "] Officer Note");
            }
        }

        [Parser(Opcode.CMSG_GUILD_QUERY)]
        public static void HandleGuildQuery(Packet packet)
        {
            packet.ReadUInt32("Guild Id");
        }

        [Parser(Opcode.SMSG_GUILD_QUERY_RESPONSE)]
        public static void HandleGuildQueryResponse(Packet packet)
        {
            packet.ReadUInt32("Guild Id");
            packet.ReadCString("Name");
            for (var i = 0; i < 10; i++)
                packet.ReadCString("[" + i + "] Name");

            ReadEmblemInfo(packet);
            packet.ReadUInt32("Ranks");
        }

        [Parser(Opcode.CMSG_GUILD_CREATE)]
        [Parser(Opcode.CMSG_GUILD_INVITE)]
        [Parser(Opcode.CMSG_GUILD_PROMOTE)]
        [Parser(Opcode.CMSG_GUILD_DEMOTE)]
        [Parser(Opcode.CMSG_GUILD_REMOVE)]
        [Parser(Opcode.CMSG_GUILD_LEADER)]
        [Parser(Opcode.CMSG_GUILD_ADD_RANK)]
        public static void HandleGuildCreate(Packet packet)
        {
            packet.ReadCString("Name");
        }

        [Parser(Opcode.SMSG_GUILD_INVITE)]
        public static void HandleGuildInvitePacket(Packet packet)
        {
            packet.ReadCString("Invitee Name");
            packet.ReadCString("Guild Name");
        }

        [Parser(Opcode.SMSG_GUILD_INFO)]
        public static void HandleGuildInfoPacket(Packet packet)
        {
            packet.ReadCString("Name");
            packet.ReadPackedTime("Creation Date");
            packet.ReadUInt32("Number of Players");
            packet.ReadUInt32("Number of Accounts");
        }

        [Parser(Opcode.CMSG_GUILD_MOTD)]
        public static void HandleGuildMOTD(Packet packet)
        {
            packet.ReadCString("MOTD");
        }

        [Parser(Opcode.SMSG_GUILD_EVENT)]
        public static void HandleGuildEvent(Packet packet)
        {
            packet.ReadEnum<GuildEventType>("Event Type", TypeCode.Byte);
            var size = packet.ReadByte("Param Count");
            for (var i = 0; i < size; i++)
                packet.ReadCString("[" + i + "]");

            if (packet.GetPosition() != packet.GetLength())
                packet.ReadGuid("GUID");
        }

        [Parser(Opcode.SMSG_GUILD_COMMAND_RESULT)]
        public static void HandleGuildCommandResult(Packet packet)
        {
            packet.ReadEnum<GuildCommandType>("Command Type", TypeCode.UInt32);
            packet.ReadCString("Param");
            packet.ReadEnum<GuildCommandError>("Command Result", TypeCode.UInt32);
        }

        [Parser(Opcode.MSG_SAVE_GUILD_EMBLEM)]
        public static void HandleGuildEmblem(Packet packet)
        {
            if (packet.Direction == Direction.ClientToServer)
            {
                packet.ReadGuid("GUID");
                ReadEmblemInfo(packet);
            }
            else
                packet.ReadEnum<GuildEmblemError>("Result", TypeCode.UInt32);
        }

        [Parser(Opcode.CMSG_GUILD_SET_PUBLIC_NOTE)]
        public static void HandleGuildSetPublicNote(Packet packet)
        {
            packet.ReadCString("Player Name");
            packet.ReadCString("Public Note");
        }

        [Parser(Opcode.CMSG_GUILD_SET_OFFICER_NOTE)]
        public static void HandleGuildSetOfficerNote(Packet packet)
        {
            packet.ReadCString("Player Name");
            packet.ReadCString("Officer Note");
        }

        [Parser(Opcode.CMSG_GUILD_INFO_TEXT)]
        public static void HandleGuildInfoText(Packet packet)
        {
            packet.ReadCString("Text");
        }

        [Parser(Opcode.CMSG_GUILD_BANKER_ACTIVATE)]
        public static void HandleGuildBankerActivate(Packet packet)
        {
            packet.ReadGuid("GUID");
            packet.ReadBoolean("Full Slot List");
        }

        [Parser(Opcode.CMSG_GUILD_BANK_QUERY_TAB)]
        public static void HandleGuildBankQueryTab(Packet packet)
        {
            packet.ReadGuid("GUID");
            packet.ReadByte("Tab Id");
            packet.ReadBoolean("Full Slot List"); // false = only slots updated in last operation are shown. True = all slots updated
        }

        [Parser(Opcode.SMSG_GUILD_BANK_LIST)]
        public static void HandleGuildBankList(Packet packet)
        {
            packet.ReadUInt64("Money");
            var tabId = packet.ReadByte("Tab Id");
            packet.ReadInt32("Remaining Withdraw");
            if (packet.ReadBoolean("Full Slot List") && tabId == 0)
            {
                var size = packet.ReadByte("Number of Tabs");
                for (var i = 0; i < size; i++)
                {
                    packet.ReadCString("[" + i + "] Tab Name");
                    packet.ReadCString("[" + i + "] Tab Icon");
                }
            }

            var slots = packet.ReadByte("Number of Slots");
            for (var i = 0; i < slots; i++)
            {
                packet.ReadByte("[" + i + "] Slot Id");
                var entry = packet.ReadUInt32("[" + i + "] Item Entry");
                if (entry > 0)
                {
                    packet.ReadEnum<ItemFlag>("[" + i + "] Item Flags?", TypeCode.UInt32);
                    var ramdonEnchant = packet.ReadInt32("[" + i + "] Random Item Property Id");
                    if (ramdonEnchant != 0)
                        packet.ReadUInt32("[" + i + "] Item Suffix Factor");
                    packet.ReadUInt32("[" + i + "] Stack Count");
                    packet.ReadUInt32("[" + i + "] Unk Uint32 2"); // Only seen 0
                    packet.ReadByte("[" + i + "] Spell Charges");
                    var enchantment = packet.ReadByte("[" + i + "] Number of Enchantments");
                    for (var j = 0; j < enchantment; j++)
                    {
                        packet.ReadByte("[" + i + "][" + j + "] Enchantment Slot Id");
                        packet.ReadUInt32("[" + i + "][" + j + "] Enchantment Id");
                    }
                }
            }
        }

        [Parser(Opcode.CMSG_GUILD_BANK_SWAP_ITEMS)]
        public static void HandleGuildBankSwapItems(Packet packet)
        {
            packet.ReadGuid("GUID");
            var bankToBank = packet.ReadBoolean("BankToBank");
            if (bankToBank)
            {
                packet.ReadByte("Dest Tab Id");
                packet.ReadByte("Dest Slot Id");
                packet.ReadUInt32("Dest Item Entry");
                packet.ReadByte("Tab Id");
                packet.ReadByte("Slot Id");
                packet.ReadUInt32("Item Entry");
                packet.ReadByte("Unk Byte 1");
                packet.ReadUInt32("Amount");
            }
            else
            {
                packet.ReadByte("Tab Id");
                packet.ReadByte("Slot Id");
                packet.ReadUInt32("Item Entry");
                var autostore = packet.ReadBoolean("Autostore");
                if (autostore)
                {
                    packet.ReadUInt32("Autostore Count");
                    packet.ReadBoolean("From Bank To Player");
                    packet.ReadUInt32("Unk Uint32 2");
                }
                else
                {
                    packet.ReadByte("Bag");
                    packet.ReadByte("Slot");
                    packet.ReadBoolean("From Bank To Player");
                    packet.ReadUInt32("Amount");
                }
            }
        }

        [Parser(Opcode.CMSG_GUILD_BANK_BUY_TAB)]
        public static void HandleGuildBankBuyTab(Packet packet)
        {
            packet.ReadGuid("GUID");
            packet.ReadByte("Tab Id");
        }

        [Parser(Opcode.CMSG_GUILD_BANK_UPDATE_TAB)]
        public static void HandleGuildBankUpdateTab(Packet packet)
        {
            packet.ReadGuid("GUID");
            packet.ReadByte("Tab Id");
            packet.ReadCString("Tab Name");
            packet.ReadCString("Tab Icon");
        }

        [Parser(Opcode.CMSG_GUILD_BANK_DEPOSIT_MONEY)]
        [Parser(Opcode.CMSG_GUILD_BANK_WITHDRAW_MONEY)]
        public static void HandleGuildBankDepositMoney(Packet packet)
        {
            packet.ReadGuid("GUID");
            packet.ReadUInt32("Money");
        }

        [Parser(Opcode.MSG_QUERY_GUILD_BANK_TEXT)]
        public static void HandleGuildQueryBankText(Packet packet)
        {
            packet.ReadByte("Tab Id");
            if (packet.Direction == Direction.ServerToClient)
                packet.ReadCString("Text");
        }

        [Parser(Opcode.CMSG_SET_GUILD_BANK_TEXT)]
        public static void HandleGuildSetBankText(Packet packet)
        {
            packet.ReadByte("Tab Id");
            packet.ReadCString("Tab Text");
        }

        [Parser(Opcode.MSG_GUILD_PERMISSIONS)]
        public static void HandleGuildPermissions(Packet packet)
        {
            if (packet.Direction == Direction.ClientToServer)
                return;

            packet.ReadUInt32("Rank Id");
            packet.ReadEnum<GuildRankRightsFlag>("Rights", TypeCode.UInt32);
            packet.ReadInt32("Remaining Money");
            packet.ReadByte("Tab size");
            for (var i = 0; i < 6; i++)
            {
                packet.ReadEnum<GuildBankRightsFlag>("[" + i + "] Tab Rights", TypeCode.Int32);
                packet.ReadInt32("[" + i + "] Tab Slots");
            }
        }

        [Parser(Opcode.MSG_GUILD_BANK_MONEY_WITHDRAWN)]
        public static void HandleGuildBankMoneyWithdrawn(Packet packet)
        {
            if (packet.Direction == Direction.ServerToClient)
                packet.ReadUInt32("Remaining Money");
        }

        [Parser(Opcode.MSG_GUILD_EVENT_LOG_QUERY)]
        public static void HandleGuildEventLogQuery(Packet packet)
        {
            if (packet.Direction == Direction.ClientToServer)
                return;

            var size = packet.ReadByte("Log size");
            for (var i = 0; i < size; i++)
            {
                var type = packet.ReadEnum<GuildEventLogType>("Type", TypeCode.Byte);
                packet.ReadGuid("GUID");
                if (type != GuildEventLogType.JoinGuild && type != GuildEventLogType.LeaveGuild)
                    packet.ReadGuid("GUID 2");
                if (type == GuildEventLogType.PromotePlayer || type == GuildEventLogType.DemotePlayer)
                    packet.ReadByte("Rank");
                packet.ReadUInt32("Time Ago");
            }
        }

        [Parser(Opcode.MSG_GUILD_BANK_LOG_QUERY)]
        public static void HandleGuildBankLogQuery(Packet packet)
        {
            packet.ReadByte("Tab Id");
            if (packet.Direction == Direction.ServerToClient)
            {
                var size = packet.ReadByte("Size");
                for (var i = 0 ; i < size; i++)
                {
                    var type = packet.ReadEnum<GuildBankEventLogType>("[" + i + "] Bank Log Event Type", TypeCode.Byte);
                    packet.ReadGuid("[" + i + "] GUID");
                    if (type == GuildBankEventLogType.BuySlot)
                        packet.ReadUInt32("[" + i + "] Cost");
                    else
                    {
                        if (type == GuildBankEventLogType.DepositMoney ||
                            type == GuildBankEventLogType.WithdrawMoney ||
                            type == GuildBankEventLogType.RepairMoney)
                            packet.ReadUInt32("[" + i + "] Money");
                        else
                        {
                            packet.ReadUInt32("[" + i + "] Item Entry");
                            packet.ReadUInt32("[" + i + "] Stack Count");
                            if (type == GuildBankEventLogType.MoveItem ||
                                type == GuildBankEventLogType.MoveItem2)
                                packet.ReadByte("[" + i + "] Tab Id");
                        }
                    }
                    packet.ReadUInt32("[" + i + "] Time");
                }
            }
        }

        // Missing Opcodes
        //[Parser(Opcode.CMSG_MAELSTROM_RENAME_GUILD)]
        //[Parser(Opcode.SMSG_GUILD_DECLINE)]
        //[Parser(Opcode.UMSG_UPDATE_GUILD)]
        //[Parser(Opcode.UMSG_DELETE_GUILD_CHARTER)]

        [Parser(Opcode.SMSG_PETITION_SHOWLIST)]
        public static void HandlePetitionShowList(Packet packet)
        {
            packet.ReadGuid("GUID");
            var counter = packet.ReadByte("Counter");
            for (var i = 0; i < counter; i++)
            {
                packet.ReadUInt32("Index");
                packet.ReadUInt32("Charter Entry");
                packet.ReadUInt32("Charter Display");
                packet.ReadUInt32("Charter Cost");
                packet.ReadUInt32("Unk Uint32 1");
                packet.ReadUInt32("Required signs");
            }
        }

        [Parser(Opcode.CMSG_PETITION_BUY)]
        public static void HandlePetitionBuy(Packet packet)
        {
            packet.ReadGuid("GUID");
            packet.ReadUInt32("Unk UInt32 1");
            packet.ReadUInt64("Unk UInt64 1");
            packet.ReadCString("Name");
            packet.ReadCString("Text");
            packet.ReadUInt32("Unk UInt32 2");
            packet.ReadUInt32("Unk UInt32 3");
            packet.ReadUInt32("Unk UInt32 4");
            packet.ReadUInt32("Unk UInt32 5");
            packet.ReadUInt32("Unk UInt32 6");
            packet.ReadUInt32("Unk UInt32 7");
            packet.ReadUInt32("Unk UInt32 8");
            packet.ReadUInt16("Unk UInt16 1");
            packet.ReadUInt32("Unk UInt32 9");
            packet.ReadUInt32("Unk UInt32 10");
            packet.ReadUInt32("Unk UInt32 11");

            for (var i = 0; i < 10; i++)
                packet.ReadCString("[" + i + "] Unk String");

            packet.ReadUInt32("Client Index");
            packet.ReadUInt32("Unk UInt32 12");
        }

        [Parser(Opcode.CMSG_PETITION_SHOW_SIGNATURES)]
        public static void HandlePetitionShowSignatures(Packet packet)
        {
            packet.ReadGuid("Petition GUID");
        }

        [Parser(Opcode.SMSG_PETITION_SHOW_SIGNATURES)]
        public static void HandlePetitionShowSignaturesServer(Packet packet)
        {
            packet.ReadGuid("Petition GUID");
            packet.ReadGuid("Owner GUID");
            packet.ReadUInt32("Guild/Team GUID");
            var counter = packet.ReadByte("Sign count");
            for (var i = 0; i < counter; i++)
            {
                packet.ReadGuid("[" + i + "] Player GUID");
                packet.ReadUInt32("[" + i + "] Unk UInt32 1");
            }
        }

        [Parser(Opcode.CMSG_PETITION_SIGN)]
        public static void HandlePetitionSign(Packet packet)
        {
            packet.ReadGuid("Petition GUID");
            packet.ReadByte("Unk Byte 1");
        }

        [Parser(Opcode.SMSG_PETITION_SIGN_RESULTS)]
        public static void HandlePetitionSignResult(Packet packet)
        {
            packet.ReadGuid("Petition GUID");
            packet.ReadGuid("Player GUID");
            packet.ReadEnum<PetitionResultType>("Petition Result", TypeCode.UInt32);
        }

        [Parser(Opcode.MSG_PETITION_DECLINE)]
        public static void HandlePetitionDecline(Packet packet)
        {
            if (packet.Direction == Direction.ClientToServer)
                packet.ReadGuid("Petition GUID");
            else
                packet.ReadGuid("Player GUID");
        }

        [Parser(Opcode.CMSG_OFFER_PETITION)]
        public static void HandlePetitionOffer(Packet packet)
        {
            packet.ReadUInt32("Unk UInt3 1");
            packet.ReadGuid("Petition GUID");
            packet.ReadGuid("Owner GUID");
        }

        [Parser(Opcode.CMSG_TURN_IN_PETITION)]
        public static void HandlePetitionTurnIn(Packet packet)
        {
            packet.ReadGuid("Petition GUID");
        }

        [Parser(Opcode.SMSG_TURN_IN_PETITION_RESULTS)]
        public static void HandlePetitionTurnInResults(Packet packet)
        {
            packet.ReadEnum<PetitionResultType>("Result", TypeCode.UInt32);
        }

        [Parser(Opcode.CMSG_PETITION_QUERY)]
        public static void HandlePetitionQuery(Packet packet)
        {
            packet.ReadUInt32("Guild/Team GUID");
            packet.ReadGuid("Petition GUID");
        }

        [Parser(Opcode.SMSG_PETITION_QUERY_RESPONSE)]
        public static void HandlePetitionQueryResponse(Packet packet)
        {
            packet.ReadUInt32("Guild/Team GUID");
            packet.ReadGuid("Owner GUID");
            packet.ReadCString("Name");
            packet.ReadCString("Text");
            packet.ReadUInt32("Signs Needed");
            packet.ReadUInt32("Signs Needed");
            packet.ReadUInt32("Unk UInt32 4");
            packet.ReadUInt32("Unk UInt32 5");
            packet.ReadUInt32("Unk UInt32 6");
            packet.ReadUInt32("Unk UInt32 7");
            packet.ReadUInt32("Unk UInt32 8");
            packet.ReadUInt16("Unk UInt16 1");
            packet.ReadUInt32("Unk UInt32 (Level?)");
            packet.ReadUInt32("Unk UInt32 (Level?)");
            packet.ReadUInt32("Unk UInt32 11");

            for (var i = 0; i < 10; i++)
                packet.ReadCString("[" + i + "] Unk String");

            packet.ReadUInt32("Client Index");
            packet.ReadUInt32("Petition Type (0: Guild / 1: Arena)");
        }

        [Parser(Opcode.MSG_PETITION_RENAME)]
        public static void HandlePetitionRename(Packet packet)
        {
            packet.ReadGuid("Petition GUID");
            packet.ReadCString("New Name");
        }

        [Parser(Opcode.SMSG_OFFER_PETITION_ERROR)]
        public static void HandlePetitionError(Packet packet)
        {
            packet.ReadGuid("Petition GUID");
        }

        [Parser(Opcode.CMSG_GUILD_RANK)]
        public static void HandleGuildRank(Packet packet)
        {
            packet.ReadUInt32("Rank Id");
            packet.ReadEnum<GuildRankRightsFlag>("Rights", TypeCode.UInt32);
            packet.ReadCString("Name");
            packet.ReadInt32("Money Per Day");
            for (var i = 0; i < 6; i++)
            {
                packet.ReadEnum<GuildBankRightsFlag>("[" + i + "] Tab Rights", TypeCode.UInt32);
                packet.ReadInt32("[" + i + "] Tab Slots");
            }
        }

        [Parser(Opcode.SMSG_GUILD_RANK)] // Cata only opcode
        public static void HandleGuildRankServer(Packet packet)
        {
            const int guildBankMaxTabs = 8;

            var count = packet.ReadUInt32("Rank Count");
            for (int i = 0; i < count; i++)
            {
                packet.ReadUInt32("[" + i + "] " + "Unk1");
                packet.ReadUInt32("[" + i + "] " + "Unk2");

                packet.ReadCString("[" + i + "] " + "Name");
                packet.ReadEnum<GuildRankRightsFlag>("Rights", TypeCode.UInt32);

                for (int j = 0; j < guildBankMaxTabs; j++)
                    packet.ReadEnum<GuildRankRightsFlag>("[" + i + "]" + "[" + j + "] " + "Tab Rights", TypeCode.UInt32);
                for (int j = 0; j < guildBankMaxTabs; j++)
                    packet.ReadUInt32("[" + i + "]" + "[" + j + "] " + "Tab Slots"); // Unsure about this. Seems to be rights aswell

                packet.ReadUInt32("[" + i + "] " + "Bank Money Per Day");

                if (i != count - 1)
                    Console.WriteLine("--");
            }
        }
    }
}
